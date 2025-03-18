using EterLibrary.Application.Services;
using EterLibrary.Domain.Entities.DbModels;
using EterPharmaPro.Core;
using EterPharmaPro.Models;
using EterPharmaPro.Utils.Extencions;
using Timer = System.Windows.Forms.Timer;

namespace EterPharmaPro.Views
{
	public partial class AcesUser : Form
	{
		private List<UserDbModel> userModels;
		public bool loginSucced = false;

		private Timer timer;
		private int targetY;
		private const int animationStep = 20;
		private bool pClose = false;
		public bool exit = false;

		//406, 252 - 406, 176

		public AcesUser()
		{
			SetCache();
			timer = new Timer();
			timer.Interval = 15;
			timer.Tick += Timer_Tick;

			InitializeComponent();

			this.Size = new System.Drawing.Size(406, 176);
		}

		public async void SetCache()
		{
			userModels = (await EterCache.Instance.EterDb.UserService.GetAllIncudeAsync()).ToList().Where(x => x.STATUS == true).ToList();
		}

		private void Timer_Tick(object sender, EventArgs e)
		{
			if (this.Top > targetY)
			{

				this.Top -= animationStep;


				if (this.Top <= targetY)
				{
					pClose = true;
					this.Close();
					timer.Stop();
				}
			}
		}

		private void ePictureBox_acess_Click(object sender, EventArgs e)
		{
			try
			{
				UserDbModel temp = userModels[comboBox_user.SelectedIndex];



				if (!string.IsNullOrEmpty(temp.PASS))
				{
					if (!string.IsNullOrEmpty(textBox_pass.Text) && PasswordHelper.VerifyPassword(textBox_pass.Text, temp.PASS))
					{
						loginSucced = true;
						EterCache.Instance.UserDbModel = temp;
						this.Close();
					}
					else
					{
						MessageBox.Show("Sua senha está incorreta.", "ALGO ERRADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					return;
				}
				else
				{
					loginSucced = true;
					EterCache.Instance.UserDbModel = temp;
					this.Close();
				}
			}
			catch (Exception ex)
			{
				ex.ErrorGet();
			}

		}

		private void AcesUser_LoadAsync(object sender, EventArgs e)
		{
			comboBox_user.CBListGeneric(userModels.Select(x => new ViewCbModel { ID = x.ID, NAME = $"{x.ID_LOJA.ToString().PadRight(4, '0')} - {x.NOME} - {x?.Position?.NOME}" }).ToList());
		}

		private void comboBox_user_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				ePictureBox_acess_Click(null, null);
			}
		}

		private void textBox_pass_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				ePictureBox_acess_Click(null, null);
			}
		}

		private void AcesUser_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!pClose)
			{
				targetY = this.Top - 255 - 200;
				timer.Start();
				e.Cancel = true;
			}


		}

		private void comboBox_user_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				UserDbModel temp = userModels[comboBox_user.SelectedIndex];

				if (temp == null) { return; }

				if (string.IsNullOrEmpty(temp.PASS))
				{
					this.Size = new System.Drawing.Size(406, 176);
					groupBox_pass.Visible = false;
				}
				else
				{
					groupBox_pass.Visible = true;
					this.Size = new System.Drawing.Size(406, 252);
				}
			}
			catch
			{
			}


		}

		private void ePictureBox_close_Click(object sender, EventArgs e)
		{
			pClose = exit = true;

			Application.Exit();
		}
	}
}
