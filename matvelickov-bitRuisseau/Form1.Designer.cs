﻿namespace matvelickov_bitRuisseau
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.upload_media = new System.Windows.Forms.Button();
            this.file_dialog = new System.Windows.Forms.OpenFileDialog();
            this.media_list = new System.Windows.Forms.ListView();
            this.mediaList = new System.Windows.Forms.ListBox();
            this.delete_media = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // upload_media
            // 
            this.upload_media.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upload_media.Location = new System.Drawing.Point(34, 379);
            this.upload_media.Name = "upload_media";
            this.upload_media.Size = new System.Drawing.Size(145, 39);
            this.upload_media.TabIndex = 0;
            this.upload_media.Text = "Charger un média";
            this.upload_media.UseVisualStyleBackColor = true;
            this.upload_media.Click += new System.EventHandler(this.upload_media_Click);
            // 
            // media_list
            // 
            this.media_list.HideSelection = false;
            this.media_list.Location = new System.Drawing.Point(34, 54);
            this.media_list.Name = "media_list";
            this.media_list.Size = new System.Drawing.Size(233, 30);
            this.media_list.TabIndex = 2;
            this.media_list.UseCompatibleStateImageBehavior = false;
            // 
            // mediaList
            // 
            this.mediaList.FormattingEnabled = true;
            this.mediaList.Location = new System.Drawing.Point(326, 54);
            this.mediaList.Name = "mediaList";
            this.mediaList.Size = new System.Drawing.Size(423, 264);
            this.mediaList.TabIndex = 3;
            this.mediaList.SelectedIndexChanged += new System.EventHandler(this.mediaList_SelectedIndexChanged);
            // 
            // delete_media
            // 
            this.delete_media.Enabled = false;
            this.delete_media.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_media.Location = new System.Drawing.Point(708, 379);
            this.delete_media.Name = "delete_media";
            this.delete_media.Size = new System.Drawing.Size(41, 39);
            this.delete_media.TabIndex = 4;
            this.delete_media.Text = "x";
            this.delete_media.UseVisualStyleBackColor = true;
            this.delete_media.Click += new System.EventHandler(this.delete_media_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.delete_media);
            this.Controls.Add(this.mediaList);
            this.Controls.Add(this.media_list);
            this.Controls.Add(this.upload_media);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button upload_media;
        private System.Windows.Forms.OpenFileDialog file_dialog;
        private System.Windows.Forms.ListView media_list;
        private System.Windows.Forms.ListBox mediaList;
        private System.Windows.Forms.Button delete_media;
    }
}

