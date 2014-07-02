using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RezervacijeSportskihTerena
{

    public partial class frmRezervacije : Form
    {
        #region Member Variables
        StringFormat strFormat; //Used to format the grid rows.
        ArrayList arrColumnLefts = new ArrayList();//Used to save left coordinates of columns
        ArrayList arrColumnWidths = new ArrayList();//Used to save column widths
        int iCellHeight = 0; //Used to get/set the datagridview cell height
        int iTotalWidth = 0; //
        int iRow = 0;//Used as counter
        bool bFirstPage = false; //Used to check whether we are printing first page
        bool bNewPage = false;// Used to check whether we are printing a new page
        int iHeaderHeight = 0; //Used for the header height
        #endregion

        /* omogućeno kreiranje samo jedne instance određene forme */
        private static frmRezervacije instance;
        /* provjera postoji li već instanca tražene forme */
        public static frmRezervacije GetInstance()
        {
            if (instance == null)
                instance = new frmRezervacije();
            return instance;
        }
        public frmRezervacije()
        {
            InitializeComponent();

            this.idRezervacija.DataPropertyName = "idRezervacija";
            this.imePrezimeKorisnik.DataPropertyName = "imePrezimeKorisnik";
            this.emailKorisnik.DataPropertyName = "emailKorisnik";
            this.telefonKorisnik.DataPropertyName = "telefonKorisnik";
            this.nazivTerena.DataPropertyName = "nazivTerena";
            this.cijenaSata.DataPropertyName = "cijenaSata";
            this.vrijemePocetka.DataPropertyName = "vrijemePocetka";
            this.vrijemeZavrsetka.DataPropertyName = "vrijemeZavrsetka";
            this.datumRezervacije.DataPropertyName = "datumRezervacije";

            List<RezervacijeClass> listaRez = RezervacijeClass.DohvatiRezervacije();
            // omogucavanje sortiranja liste rezervacija uz pomoc SortableBindingList klase
            SortableBindingList<RezervacijeClass> sortiranaListaRez = new SortableBindingList<RezervacijeClass>(listaRez);
            this.dgvRezervacije.DataSource = sortiranaListaRez;
        }

        public void OsvjeziRezervacije()
        {
            List<RezervacijeClass> listaRez = RezervacijeClass.DohvatiRezervacije();
            SortableBindingList<RezervacijeClass> sortiranaListaRez = new SortableBindingList<RezervacijeClass>(listaRez);
            this.dgvRezervacije.DataSource = sortiranaListaRez;
        }

        private void frmRezervacije_FormClosing(object sender, FormClosingEventArgs e)
        {
            instance = null;
        }

        private void btnNovaRezervacija_Click(object sender, EventArgs e)
        {
            frmNovaRezervacija rez = new frmNovaRezervacija();
            rez.ShowDialog();
            OsvjeziRezervacije();
        }

        private void frmRezervacije_Load(object sender, EventArgs e)
        {
            OsvjeziRezervacije();
        }

        private void btnObrisiRezervaciju_Click(object sender, EventArgs e)
        {
            // Iz selektiranog reda izvlači se vrijednost IdRezervacija i prosljeđuje na funkciju Obrisi
            int selectedRowIndexR = dgvRezervacije.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRowR = dgvRezervacije.Rows[selectedRowIndexR];
            int a = Convert.ToInt32(selectedRowR.Cells["IdRezervacija"].Value);

            RezervacijeAkcijeClass rez = new RezervacijeAkcijeClass();
            rez.Obrisi(a);
               
            OsvjeziRezervacije();
        }

        #region Print Button Click Event
        private void btnIspisiRezervaciju_Click(object sender, EventArgs e)
        {
            //Open the print dialog
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument1;
            printDialog.UseEXDialog = true;
            printDocument1.DefaultPageSettings.Landscape = true;
            //Get the document
            if (DialogResult.OK == printDialog.ShowDialog())
            {
                printDocument1.DocumentName = "Rezervacija sportskih termina";
                printDocument1.Print();
            }           
        }
        #endregion

        #region Begin Print Event Handler
        /// <summary>
        /// Handles the begin print page event of print document
        /// </summary>
        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                strFormat = new StringFormat();
                strFormat.Alignment = StringAlignment.Near;
                strFormat.LineAlignment = StringAlignment.Center;
                strFormat.Trimming = StringTrimming.EllipsisCharacter;

                arrColumnLefts.Clear();
                arrColumnWidths.Clear();
                iCellHeight = 0;
                bFirstPage = true;
                bNewPage = true;

                // Calculating Total Widths
                iTotalWidth = 0;
                foreach (DataGridViewColumn dgvGridCol in dgvRezervacije.Columns)
                {
                    iTotalWidth += dgvGridCol.Width;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Print Page Event
        /// <summary>
        /// Handles the print page event of print document
        /// </summary>
        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                //Set the left margin
                int iLeftMargin = e.MarginBounds.Left;
                //Set the top margin
                int iTopMargin = e.MarginBounds.Top;
                //Whether more pages have to print or not
                bool bMorePagesToPrint = false;
                int iTmpWidth = 0;

                //For the first page to print set the cell width and header height
                if (bFirstPage)
                {
                    foreach (DataGridViewColumn GridCol in dgvRezervacije.Columns)
                    {
                        iTmpWidth = (int)(Math.Floor((double)((double)GridCol.Width /
                                       (double)iTotalWidth * (double)iTotalWidth *
                                       ((double)e.MarginBounds.Width / (double)iTotalWidth))));

                        iHeaderHeight = (int)(e.Graphics.MeasureString(GridCol.HeaderText,
                                    GridCol.InheritedStyle.Font, iTmpWidth).Height) + 11;

                        // Save width and height of headres
                        arrColumnLefts.Add(iLeftMargin);
                        arrColumnWidths.Add(iTmpWidth);
                        iLeftMargin += iTmpWidth;
                    }
                }
                //Loop till all the grid rows not get printed
                while (iRow <= dgvRezervacije.Rows.Count - 1)
                {
                    DataGridViewRow GridRow = dgvRezervacije.Rows[iRow];
                    //Set the cell height
                    iCellHeight = GridRow.Height + 5;
                    int iCount = 0;
                    //Check whether the current page settings allo more rows to print
                    if (iTopMargin + iCellHeight >= e.MarginBounds.Height + e.MarginBounds.Top)
                    {
                        bNewPage = true;
                        bFirstPage = false;
                        bMorePagesToPrint = true;
                        break;
                    }
                    else
                    {
                        if (bNewPage)
                        {
                            //Draw Header
                            e.Graphics.DrawString("Rezervacija sportskih terena", new Font(dgvRezervacije.Font, FontStyle.Regular),
                                    Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top -
                                    e.Graphics.MeasureString("Rezervacija sportskih terena", new Font(dgvRezervacije.Font,
                                    FontStyle.Regular), e.MarginBounds.Width).Height - 13);

                            String strDate = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString();
                            //Draw Date
                            e.Graphics.DrawString(strDate, new Font(dgvRezervacije.Font, FontStyle.Regular),
                                    Brushes.Black, e.MarginBounds.Left + (e.MarginBounds.Width -
                                    e.Graphics.MeasureString(strDate, new Font(dgvRezervacije.Font,
                                    FontStyle.Regular), e.MarginBounds.Width).Width), e.MarginBounds.Top -
                                    e.Graphics.MeasureString("Rezervacija sportskih terena", new Font(new Font(dgvRezervacije.Font,
                                    FontStyle.Regular), FontStyle.Regular), e.MarginBounds.Width).Height - 13);

                            //Draw Columns                 
                            iTopMargin = e.MarginBounds.Top;
                            foreach (DataGridViewColumn GridCol in dgvRezervacije.Columns)
                            {
                                e.Graphics.FillRectangle(new SolidBrush(Color.LightGray),
                                    new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawRectangle(Pens.Black,
                                    new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawString(GridCol.HeaderText, GridCol.InheritedStyle.Font,
                                    new SolidBrush(GridCol.InheritedStyle.ForeColor),
                                    new RectangleF((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight), strFormat);
                                iCount++;
                            }
                            bNewPage = false;
                            iTopMargin += iHeaderHeight;
                        }
                        iCount = 0;
                        //Draw Columns Contents                
                        foreach (DataGridViewCell Cel in GridRow.Cells)
                        {
                            if (Cel.Value != null)
                            {
                                e.Graphics.DrawString(Cel.Value.ToString(), Cel.InheritedStyle.Font,
                                            new SolidBrush(Cel.InheritedStyle.ForeColor),
                                            new RectangleF((int)arrColumnLefts[iCount], (float)iTopMargin,
                                            (int)arrColumnWidths[iCount], (float)iCellHeight), strFormat);
                            }
                            //Drawing Cells Borders 
                            e.Graphics.DrawRectangle(Pens.Black, new Rectangle((int)arrColumnLefts[iCount],
                                    iTopMargin, (int)arrColumnWidths[iCount], iCellHeight));

                            iCount++;
                        }
                    }
                    iRow++;
                    iTopMargin += iCellHeight;
                }

                //If more lines exist, print another page.
                if (bMorePagesToPrint)
                    e.HasMorePages = true;
                else
                    e.HasMorePages = false;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Kod za print funkcionalnost preuzet sa http://www.codeproject.com/Articles/28046/Printing-of-DataGridView
        #endregion
    }
}
