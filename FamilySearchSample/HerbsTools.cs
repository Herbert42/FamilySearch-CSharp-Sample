﻿using System.Windows.Forms;

namespace FamilySearchSample
{
    public static class HerbsTools
    {
        /// <summary>
        /// Recursively clear Text in all textboxes, regardless where they are on the form.
        /// </summary>
        /// <param name="parentObject">Collection of controls</param>
        public static void ClearAllTextBoxes(Control.ControlCollection parentObject)
        {
            foreach (Control childObject in parentObject)
            {
                //See if we have a textBox.
                TextBox childTextBox = childObject as TextBox;

                if (childTextBox != null)
                    //TextBox found.
                    childTextBox.Clear();
                else
                    //Not a textBox, keep looking.
                    ClearAllTextBoxes(childObject.Controls);
            }
        }
    }
}
