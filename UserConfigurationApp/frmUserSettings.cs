using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserConfigurationApp
{
    public partial class frmUserSettings : Form
    {
        public frmUserSettings()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (cmbDepartment.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un departamento.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string configurationSummary = GenerateConfigurationSummary();
            MessageBox.Show(configurationSummary, "Resumen de Configuración",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private string GenerateConfigurationSummary()
        {
            string role = rdoAdmin.Checked ? "Administrador" : "Usuario Regular";
            string department = cmbDepartment.SelectedItem != null ? cmbDepartment.SelectedItem.ToString() : "No seleccionado";
            string notifications = string.Join(", ", lstNotifications.SelectedItems.Cast<string>());
            string advancedOptions = string.Join(", ", clbAdvancedOptions.CheckedItems.Cast<string>());
            string profilePicturePath = picProfile.ImageLocation ?? "No se ha seleccionado una foto de perfil";
            string dateOfEntry = dtpDateOfEntry.Value.ToShortDateString();
            int experienceLevel = (int)numExperience.Value;

            string summary = $"Preferencias de Comunicación:\n";
            summary += $"- Email: {(chkEmail.Checked ? "Sí" : "No")}\n";
            summary += $"- SMS: {(chkSMS.Checked ? "Sí" : "No")}\n";
            summary += $"Rol de Usuario: {role}\n";
            summary += $"Departamento: {department}\n";
            summary += $"Notificaciones Seleccionadas: {notifications}\n";
            summary += $"Opciones Avanzadas: {advancedOptions}\n";
            summary += $"Foto de Perfil: {profilePicturePath}\n";
            summary += $"Fecha de Ingreso: {dateOfEntry}\n";
            summary += $"Nivel de Experiencia: {experienceLevel} años\n";

            return summary;
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Archivo de texto (*.txt)|*.txt",
                Title = "Guardar Configuración"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string configurationSummary = GenerateConfigurationSummary();
                File.WriteAllText(saveFileDialog.FileName, configurationSummary);
                MessageBox.Show("Configuración guardada exitosamente.", "Guardar Configuración", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLoadSettings_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Archivo de texto (*.txt)|*.txt",
                Title = "Cargar Configuración"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] configuration = File.ReadAllLines(openFileDialog.FileName);
                ApplyConfiguration(configuration);
                MessageBox.Show("Configuración cargada exitosamente.", "Cargar Configuración", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ApplyConfiguration(string[] configuration)
        {
            // Preferencias de comunicación
            chkEmail.Checked = configuration.Contains("- Email: Sí");
            chkSMS.Checked = configuration.Contains("- SMS: Sí");

            // Rol de usuario
            rdoAdmin.Checked = configuration.Contains("Rol de Usuario: Administrador");
            rdoUser.Checked = configuration.Contains("Rol de Usuario: Usuario Regular");

            // Selección del departamento en ComboBox
            string department = configuration.FirstOrDefault(line => line
                .StartsWith("Departamento: "))?.Split(':')[1].Trim();
            if (!string.IsNullOrEmpty(department) && cmbDepartment.Items.Contains(department))
            {
                cmbDepartment.SelectedItem = department;
            }

            // Selección de notificaciones en ListBox
            string notifications = configuration.FirstOrDefault(line =>
                line.StartsWith("Notificaciones Seleccionadas: "))?.Split(':')[1].Trim();
            if (!string.IsNullOrEmpty(notifications))
            {
                foreach (string notification in notifications.Split(',').Select(n => n.Trim()))
                {
                    int index = lstNotifications.Items.IndexOf(notification);
                    if (index >= 0)
                    {
                        lstNotifications.SetSelected(index, true);
                    }
                }
            }

            // Opciones avanzadas en CheckedListBox
            string advancedOptions = configuration.FirstOrDefault(line =>
                line.StartsWith("Opciones Avanzadas: "))?.Split(':')[1].Trim();
            if (!string.IsNullOrEmpty(advancedOptions))
            {
                foreach (string option in advancedOptions.Split(',').Select(op => op.Trim()))
                {
                    int index = clbAdvancedOptions.Items.IndexOf(option);
                    if (index >= 0)
                    {
                        clbAdvancedOptions.SetItemChecked(index, true);
                    }
                }
            }

            // Foto de Perfil
            string profilePicturePath = configuration.FirstOrDefault(line =>
                line.StartsWith("Foto de Perfil: "))?.Substring("Foto de Perfil: ".Length).Trim();
            if (!string.IsNullOrEmpty(profilePicturePath) && File.Exists(profilePicturePath))
            {
                picProfile.ImageLocation = profilePicturePath;
            }

            // Fecha de Ingreso
            string dateOfEntry = configuration.FirstOrDefault(line =>
                line.StartsWith("Fecha de Ingreso: "))?.Split(':')[1].Trim();
            if (DateTime.TryParse(dateOfEntry, out DateTime date))
            {
                dtpDateOfEntry.Value = date;
            }

            // Nivel de Experiencia
            string experienceLevel = configuration.FirstOrDefault(line =>
                line.StartsWith("Nivel de Experiencia: "))?.Split(':')[1].Trim();

            // Extrae solo el número antes de intentar convertirlo a decimal
            if (!string.IsNullOrEmpty(experienceLevel))
            {
                string numericPart = new string(experienceLevel.Where(char.IsDigit).ToArray());
                if (decimal.TryParse(numericPart, out decimal experienceValue))
                {
                    numExperience.Value = experienceValue;
                }
            }
        }

        private void btnUploadPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Imagenes (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png",
                Title = "Seleccionar Foto de Perfil"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picProfile.ImageLocation = openFileDialog.FileName;
            }
        }
    }
}
