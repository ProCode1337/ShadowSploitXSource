using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroSuite;

// Token: 0x02000015 RID: 21
public class GForm2 : MetroForm
{
	// Token: 0x0600009D RID: 157 RVA: 0x00009F4C File Offset: 0x0000814C
	public GForm2()
	{
		this.method_0();
		this.label_1.Visible = false;
		this.label_2.Visible = false;
		this.timer_0.Start();
	}

	// Token: 0x0600009E RID: 158 RVA: 0x00009F90 File Offset: 0x00008190
	private void GForm2_Load(object sender, EventArgs e)
	{
		base.TopMost = true;
	}

	// Token: 0x0600009F RID: 159 RVA: 0x00009FA4 File Offset: 0x000081A4
	private async void timer_0_Tick(object sender, EventArgs e)
	{
		this.timer_0.Stop();
		this.progressBar_0.Value = 20;
		await Task.Delay(1200);
		this.label_0.Visible = false;
		this.label_1.Visible = true;
		this.progressBar_0.Value = 74;
		await Task.Delay(1800);
		this.label_1.Visible = false;
		this.label_2.Visible = true;
		await Task.Delay(800);
		this.progressBar_0.Value = 100;
		await Task.Delay(1000);
		base.Hide();
		base.TopMost = true;
		base.TopMost = false;
		new GForm0().Show();
	}

	// Token: 0x060000A0 RID: 160 RVA: 0x00009FF0 File Offset: 0x000081F0
	protected override void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x060000A1 RID: 161 RVA: 0x0000A020 File Offset: 0x00008220
	private void method_0()
	{
		this.icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(GForm2));
		this.progressBar_0 = new ProgressBar();
		this.label_0 = new Label();
		this.label_1 = new Label();
		this.label_2 = new Label();
		this.timer_0 = new Timer(this.icontainer_0);
		base.SuspendLayout();
		this.progressBar_0.Location = new Point(12, 96);
		this.progressBar_0.Name = "progressBar1";
		this.progressBar_0.Size = new Size(356, 27);
		this.progressBar_0.TabIndex = 0;
		this.label_0.AutoSize = true;
		this.label_0.Font = new Font("Segoe UI", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.label_0.Location = new Point(143, 59);
		this.label_0.Name = "label2";
		this.label_0.Size = new Size(95, 21);
		this.label_0.TabIndex = 2;
		this.label_0.Text = "Starting up...";
		this.label_1.AutoSize = true;
		this.label_1.Font = new Font("Segoe UI", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.label_1.Location = new Point(136, 59);
		this.label_1.Name = "label1";
		this.label_1.Size = new Size(109, 21);
		this.label_1.TabIndex = 5;
		this.label_1.Text = "Setting up UI...";
		this.label_2.AutoSize = true;
		this.label_2.Font = new Font("Segoe UI", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.label_2.Location = new Point(149, 59);
		this.label_2.Name = "label4";
		this.label_2.Size = new Size(82, 21);
		this.label_2.TabIndex = 7;
		this.label_2.Text = "Finishing...";
		this.timer_0.Tick += this.timer_0_Tick;
		base.AccentColor = Color.FromArgb(104, 33, 122);
		base.AutoScaleDimensions = new SizeF(7f, 15f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(380, 147);
		base.Controls.Add(this.progressBar_0);
		base.Controls.Add(this.label_0);
		base.Controls.Add(this.label_2);
		base.Controls.Add(this.label_1);
		this.ForeColor = SystemColors.ControlDark;
		base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		base.Name = "Loading";
		base.StartPosition = FormStartPosition.CenterScreen;
		base.State = 1;
		base.Style = 1;
		this.Text = "Loading";
		base.TopMost = true;
		base.Load += this.GForm2_Load;
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	// Token: 0x040000AC RID: 172
	private IContainer icontainer_0 = null;

	// Token: 0x040000AD RID: 173
	private ProgressBar progressBar_0;

	// Token: 0x040000AE RID: 174
	private Label label_0;

	// Token: 0x040000AF RID: 175
	private Label label_1;

	// Token: 0x040000B0 RID: 176
	private Label label_2;

	// Token: 0x040000B1 RID: 177
	private Timer timer_0;
}
