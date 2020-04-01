using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin_TP_Module_04
{
    public partial class MainPage
    {
        private void Connection_Clicked(object sender, EventArgs e)
        {
            cacherErreur();
            if (this.username.Text == null || string.IsNullOrEmpty(this.username.Text.ToString()))
            {
                this.afficherErreur("Veuillez saisir un identifiant");
                return;
            }
            else if (this.username.Text.Length < 3)
            {
                this.afficherErreur("L'identifiant doit faire 3 caractères minimum");
                return;
            }

            if (this.password.Text == null || string.IsNullOrEmpty(this.password.Text.ToString()))
            {
                this.afficherErreur("Veuillez saisir un mot de passe");
                return;
            }
            else if (this.password.Text.Length < 6)
            {
                this.afficherErreur("Le mot de passe doit faire 6 caractères minimum");
                return;
            }
            this.connection_form.IsVisible = false;
            this.feed.IsVisible = true;
        }
        private void afficherErreur(string erreur)
        {
            this.erreur.Text = erreur; this.erreur.IsVisible = true;
        }

        private void cacherErreur()
        {
            this.erreur.IsVisible = false;
        }
    }
}