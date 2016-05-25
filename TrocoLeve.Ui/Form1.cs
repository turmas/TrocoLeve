using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrocoLeve.Core;
using TrocoLeve.Core.DataContracts;

namespace TrocoLeve.Ui {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		private void sairToolStripMenuItem_Click(object sender, EventArgs e) {
			Application.Exit();
		}

		private void sobreToolStripMenuItem_Click(object sender, EventArgs e) {
			AboutBox formAbout = new AboutBox();
			formAbout.ShowDialog();
		}

		private void UxBtnBuy_Click(object sender, EventArgs e) {
			Calculate();
		}

		private void Calculate() {

			long productAmount = Convert.ToInt64(UxTxtProductAmount.Text.Trim());
			long paidAmount = Convert.ToInt64(UxTxtPaidAmount.Text.Trim());

			CalculateRequest calculateRequest = new CalculateRequest(productAmount, paidAmount);
			TrocoLeveManager trocoLeveManager = new TrocoLeveManager();
			CalculateResponse calculateResponse = trocoLeveManager.Calculate(calculateRequest);

			UxLstChangeAmount.Items.Clear();

			if (calculateResponse.Success == false) {

				foreach (Report error in calculateResponse.OperationReport) {
					string errorDescription = string.Format("{0}: {1}", error.Field, error.Message);
					UxLstChangeAmount.Items.Add(errorDescription);
				}

				return;
			}

			UxLstChangeAmount.Items.Add("Troco total: " + calculateResponse.ChangeAmount);

			foreach (ChangeData changeData in calculateResponse.ChangeDataList) {
				string changeDescription = string.Format("Quantidade: {0} x {1}: {2}", changeData.Quantity,changeData.CurrencyType,changeData.Amount );
				UxLstChangeAmount.Items.Add(changeDescription);
			}

		}

		private void comprarToolStripMenuItem_Click(object sender, EventArgs e) {
			Calculate();
		}
	}
}
