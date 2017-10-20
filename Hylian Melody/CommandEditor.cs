using System;
using System.Windows.Forms;
using HylianMelody.NSPC;

namespace HylianMelody
{
    public partial class CommandEditor : Form
    {
        public Command Command { get; private set; }

        public static Command Edit(Command command = null, Song song = null)
        {
            CommandEditor editor = new CommandEditor(command, song);
            editor.ShowDialog();
            return editor.Command;
        }

        public CommandEditor(Command command = null, Song song = null)
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

            numericParameter1.Value = (command.Parameters[0] ?? -1);
            numericParameter2.Value = (command.Parameters[1] ?? -1);
            numericParameter3.Value = (command.Parameters[2] ?? -1);

            groupSubroutines.MinimumSize = groupParameters.Size;
            groupParameters.MinimumSize = groupSubroutines.Size;

            if (song != null) {
                comboSubroutines.Items.AddRange(song.Subroutines.ToArray());
            }

            comboCommand_SelectedIndexChanged(this, EventArgs.Empty);
        }

        private void comboCommand_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupSubroutines.Visible = (string.Equals(
                Enum.GetName(typeof(Command.CommandValue), Command.CommandValue.CallSubroutine),
                (string) comboCommand.SelectedItem,
                StringComparison.InvariantCultureIgnoreCase));
            groupParameters.Visible = (!groupSubroutines.Visible);
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

        private void CommandEditor_Shown(object sender, EventArgs e)
            => comboCommand_SelectedIndexChanged(sender, e);
    }
}
