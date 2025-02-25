﻿using EterPharmaPro.Controllers.Impressos;
using EterPharmaPro.Models;
using EterPharmaPro.Properties;
using EterPharmaPro.Utils.Events;
using EterPharmaPro.Utils.Extencions;
using System.Data;

namespace EterPharmaPro.Views.ReqNota
{
	public partial class ControleReqNota : Form
	{
		private RequisicaoNotasModel requisicaoNotas = null;
		private bool isNew = false;
		private bool isEdit = false;
		private DataTable dataTableView = null;

		private readonly ControleReqNotaController controller = null;

		public ControleReqNota()
		{
			InitializeComponent();
			controller = new ControleReqNotaController();
			controller.LoadReqs += Controller_LoadReqs;
			_ = controller.LoadControlReqs();
			ClearFieldReq();
		}

		private void Controller_LoadReqs(object sender, ControlReqsViewEventArgs e)
		{

			dataTableView = e.dataTable;
			RefreshDataGrid();
		}

		private void ClearFieldReq()
		{
			comboBox_vend.SelectedIndex = -1;
			dateTimePicker_data.Value = DateTime.Today;
			textBox_req.Clear();
			dataGridView_reqs.Rows.Clear();
		}
		private void dataGridView_reqs_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete)
			{

				var temp = dataGridView_reqs.SelectedCells[0].RowIndex;
				dataGridView_reqs.Rows.RemoveAt(temp);
			}
		}

		private void ePictureBox_addR_Click(object sender, System.EventArgs e)
		{
			dataGridView_reqs.Rows.Add(new object[] { string.Empty, textBox_req.Text.ToUpper() });
			textBox_req.Clear();
			textBox_req.Focus();

		}

		private void OpenSaveUp()
		{
			toolStripButton_new_save.Image = Resources.salve;
			toolStripButton_cancel.Visible = true;
			groupBox_addReq.Visible = true;
			toolStripButton_send.Visible = false;
		}
		private async void toolStripButton_new_save_Click(object sender, System.EventArgs e)
		{
			if (!isNew && !isEdit)
			{
				requisicaoNotas = new RequisicaoNotasModel();

				OpenSaveUp();
				ClearFieldReq();
				isNew = true;
			}
			else
			{
				requisicaoNotas.REQS = requisicaoNotas.REQS ?? new List<(long? id, string name)>();
				requisicaoNotas.REQS.Clear();

				for (int i = 0; i < dataGridView_reqs.Rows.Count; i++)
				{
					long? sTempId = null;

					if (!string.IsNullOrEmpty(dataGridView_reqs.Rows[i].Cells[0].Value.ToString()))
					{
						sTempId = Convert.ToUInt32(dataGridView_reqs.Rows[i].Cells[0].Value.ToString());
					}

					string sTempReq = dataGridView_reqs.Rows[i].Cells[1].Value.ToString();

					if (!string.IsNullOrEmpty(sTempReq))
					{
						requisicaoNotas.REQS.Add((sTempId, sTempReq));
					}

				}

				requisicaoNotas.REG_USERID = Convert.ToInt32(comboBox_user_red.SelectedValue);
				requisicaoNotas.USERID = Convert.ToInt32(comboBox_vend.SelectedValue);
				requisicaoNotas.DATA_VENDA = dateTimePicker_data.Value;

				if (isEdit)
				{
					if (await controller.UpdateCREQ(requisicaoNotas))
					{
						toolStripButton_cancel_Click(null, null);
						_ = controller.LoadControlReqs();
					}
				}
				else
				{
					if (await controller.CreateCREQ(requisicaoNotas))
					{
						toolStripButton_cancel_Click(null, null);
						_ = controller.LoadControlReqs();
					}
				}
			}

		}

		private void toolStripButton_cancel_Click(object sender, EventArgs e)
		{
			requisicaoNotas = null;
			toolStripButton_new_save.Image = Resources.documento_new;
			toolStripButton_cancel.Visible = false;
			groupBox_addReq.Visible = false;
			toolStripButton_send.Visible = true;
			dataGridView_reqs.Columns[0].Visible = false;
			ClearFieldReq();
			isNew = false;
			isEdit = false;
		}

		private async void toolStripButton_send_Click(object sender, EventArgs e)
		{
			List<long> list = new List<long>();
			for (int i = 0; i < dataGridView_resqDb.Rows.Count; i++)
			{
				//4 - 6
				if ((bool)dataGridView_resqDb.Rows[i].Cells[6].Value)
				{
					list.Add(Convert.ToUInt32(dataGridView_resqDb.Rows[i].Cells[0].Value));
				}
			}

			if (list.Count > 0)
			{
				if (await controller.SendReq(list))
				{
					_ = controller.LoadControlReqs();
				}
			}
		}

		private void dataGridView_resqDb_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			bool temp = (bool)dataGridView_resqDb.Rows[e.RowIndex].Cells[6].Value;
			dataGridView_resqDb.Rows[e.RowIndex].Cells[6].Value = !temp;
		}

		private async void ControleReqNota_LoadAsync(object sender, EventArgs e)
		{
			//await comboBox_user_red.CBListUserAsync(eterDb);
			////comboBox_user_red.SelectedIndex = comboBox_user_red.ReturnIndexUserCB(eterDb.EterDbController.UserModelAcess.ID);
			//await comboBox_vend.CBListUserAsync(eterDb);
		}

		private void textBox_req_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				ePictureBox_addR_Click(null, null);
			}
		}

		private async void RefreshDataGrid(bool queryData = false, object sender = null)
		{
			if (dataTableView is null)
			{
				return;
			}
			if (!queryData)
			{
				dataGridView_resqDb.DataSource = dataTableView;
			}
			else
			{
				DateTime temp = ((DateTimePicker)sender).Value;
				dataGridView_resqDb.DataSource = await controller.GetByDate(((DateTimePicker)sender));
			}
		}

		private async void dataGridView_resqDb_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			long? id = Convert.ToUInt32(dataGridView_resqDb.Rows[e.RowIndex].Cells[0].Value);
			requisicaoNotas = await controller.GetControlAndReqs(id);

			dataGridView_reqs.Columns[0].Visible = true;

			for (int i = 0; i < requisicaoNotas.REQS.Count; i++)
			{
				dataGridView_reqs.Rows.Add(new object[] { requisicaoNotas.REQS[i].id, requisicaoNotas.REQS[i].name });
			}

			comboBox_user_red.SelectedIndex = comboBox_user_red.ReturnIndexUserCB(requisicaoNotas.REG_USERID);
			comboBox_vend.SelectedIndex = comboBox_vend.ReturnIndexUserCB(requisicaoNotas.USERID);
			dateTimePicker_data.Value = (DateTime)requisicaoNotas.DATA_VENDA;
			OpenSaveUp();
			isEdit = true;
		}

		private void dateTimePicker_dataEnvio_ValueChanged(object sender, EventArgs e)
		{
			RefreshDataGrid(true, sender);
		}

		private void dateTimePicker_dataVenda_ValueChanged(object sender, EventArgs e)
		{
			RefreshDataGrid(true, sender);
		}
	}
}
