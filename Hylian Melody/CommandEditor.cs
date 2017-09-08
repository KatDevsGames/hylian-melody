using System;
using System.Windows.Forms;
using HylianMelody.NSPC;

namespace HylianMelody
{
    public partial class CommandEditor : Form
    {
        public Command Command { get; private set; }

        public static Command Edit(Command command = null)
        {
            CommandEditor editor = new CommandEditor(command);
            editor.ShowDialog();
            return editor.Command;
        }

        public CommandEditor(Command command = null)
        {
            InitializeComponent();

            foreach (string cName in Enum.GetNames(typeof(Command.CommandValue)))
            {
                comboCommand.Items.Add(cName);
            }

            if (command == null)
            {
                Command = new Command();
                return;
            }

            Command = command;

            if (command != null) {
                comboCommand.SelectedItem = Enum.GetName(typeof(Command.CommandValue), command.Value);
            }

            numericParameter1.Value = (decimal)(command.Parameters[0]??-1);
            numericParameter2.Value = (decimal)(command.Parameters[1]??-1);
            numericParameter3.Value = (decimal)(command.Parameters[2]??-1);
        }

        private void comboCommand_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
            => Close();

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (Command != null)
            {
                Command = new Command((Command.CommandValue)Enum.Parse(typeof(Command.CommandValue), (string)comboCommand.SelectedItem));

                Command.Parameters[0] = ((numericParameter1.Value < 0) ? null : (byte?)numericParameter1.Value);
                Command.Parameters[1] = ((numericParameter2.Value < 0) ? null : (byte?)numericParameter2.Value);
                Command.Parameters[2] = ((numericParameter3.Value < 0) ? null : (byte?)numericParameter3.Value);
            }
            Close();
        }
    }
}
