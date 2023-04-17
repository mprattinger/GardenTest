using GardenTest.States;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GardenTest
{
    public partial class Form2 : Form
    {
        private System.Windows.Forms.Timer _timer;

        private Water _water = new();
        private Sprinkling _sprinkling = new();
        private Pumpe _pumpe = new();

        public Form2()
        {
            InitializeComponent();

            _timer = new();
            _timer.Interval = 1000;
            _timer.Tick += _timer_Tick;
            _timer.Start();
        }

        private void _timer_Tick(object? sender, EventArgs e)
        {
            //Anfang der Schleife -> States prüfen
            _water.WaterLevelGood = cbWaterLevel.Checked;
            _water.CheckState();
            lblWaterState.Text = _water.CurrentState.ToString();
            if (_water.CurrentState != States.Water.MOVE)
            {
                _sprinkling.PreperationDone();
            }

            _sprinkling.CheckState();
            lblState.Text = _sprinkling.CurrentState;
            if(_sprinkling.CurrentState == Sprinkling.OFF)
            {
                cbWerfer.Checked = false;
                cbSprueher.Checked = false;
                cbTropfer.Checked = false;
                if (_water.CurrentState != Water.MOVE)
                {
                    _water.StopWater();
                }
            }

            if (_water.CurrentState == Water.ZISTERNE && _sprinkling.CurrentState != Sprinkling.OFF)
            {
                _pumpe.SetState(Pumpe.ON);
            }
            else
            {
                _pumpe.SetState(Pumpe.OFF);
            }
            cbPump.Checked = _pumpe.CurrentState == Pumpe.ON;
        }

        private void btnManuell_Click(object sender, EventArgs e)
        {
            _sprinkling.SetState(_sprinkling.CurrentState == Sprinkling.MANUELL ? Sprinkling.OFF : Sprinkling.MANUELL);
            if (_sprinkling.TargetState == Sprinkling.OFF)
            {
                _water.StopWater();
            }
            else
            {
                _water.GetWater();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnWerfer_Click(object sender, EventArgs e)
        {
            cbWerfer.Checked = false;
            cbSprueher.Checked = false;
            cbTropfer.Checked = false;

            _sprinkling.SetState(_sprinkling.CurrentState == Sprinkling.WERFER ? Sprinkling.OFF : Sprinkling.WERFER);
            if (_sprinkling.TargetState == Sprinkling.OFF)
            {
                _water.StopWater();
                cbWerfer.Checked = false;
            }
            else
            {
                _water.GetWater();
                cbWerfer.Checked = true;
            }
        }

        private void btnSprueher_Click(object sender, EventArgs e)
        {
            cbWerfer.Checked = false;
            cbSprueher.Checked = false;
            cbTropfer.Checked = false;

            _sprinkling.SetState(_sprinkling.CurrentState == Sprinkling.SPRÜHER ? Sprinkling.OFF : Sprinkling.SPRÜHER);
            if (_sprinkling.TargetState == Sprinkling.OFF)
            {
                _water.StopWater();
                cbSprueher.Checked = false;
            }
            else
            {
                _water.GetWater();
                cbSprueher.Checked = true;
            }
        }

        private void btnTropfer_Click(object sender, EventArgs e)
        {
            cbWerfer.Checked = false;
            cbSprueher.Checked = false;
            cbTropfer.Checked = false;

            _sprinkling.SetState(_sprinkling.CurrentState == Sprinkling.TROPFER ? Sprinkling.OFF : Sprinkling.TROPFER);
            if (_sprinkling.TargetState == Sprinkling.OFF)
            {
                _water.StopWater();
                cbTropfer.Checked = false;
            }
            else
            {
                _water.GetWater();
                cbTropfer.Checked = true;
            }
        }
    }
}
