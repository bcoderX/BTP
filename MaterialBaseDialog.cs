using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace BTP
{
    public partial class MaterialBaseDialog : Form
    {
        float rtri = 0;
        //  The texture identifier.
        uint[] textures = new uint[1];
        //  Storage the texture itself.
        Bitmap textureImage;

        float rtri1 = 0;
        //  The texture identifier.
        uint[] textures1 = new uint[1];
        //  Storage the texture itself.
        Bitmap textureImage1;

        float rtri3 = 0;
        //  The texture identifier.
        uint[] textures3 = new uint[1];
        //  Storage the texture itself.
        Bitmap textureImage3;
        public MaterialBaseDialog()
        {
            InitializeComponent();
        }



        private void sectionsTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (sectionsTreeView.SelectedNode.Name)
            {
                case "acier":
                case "acierArmature":
                case "beton":
                case "aluminium":
                case "bois":
                case "ceramique":
                case "autres":
                case "materiauStratifie":
                    if (materialBaseTable.Controls.Count == 2)
                    {
                        materialBaseTable.Controls.RemoveAt(1);
                    }
                    materialBaseTable.Controls.Add(emptyPanel, 1, 0);
                    break;
                case "acierE24":
                    if (materialBaseTable.Controls.Count == 2)
                    {
                        materialBaseTable.Controls.RemoveAt(1);
                    }
                    materialBaseTable.Controls.Add(acierE24Panel, 1, 0);
                    break;
                case "ha400":
                    if (materialBaseTable.Controls.Count == 2)
                    {
                        materialBaseTable.Controls.RemoveAt(1);
                    }
                    materialBaseTable.Controls.Add(ha400Panel, 1, 0);
                    break;
                case "b20":
                    if (materialBaseTable.Controls.Count == 2)
                    {
                        materialBaseTable.Controls.RemoveAt(1);
                    }
                    materialBaseTable.Controls.Add(b20Panel, 1, 0);
                    break;
                case "alum":
                    if (materialBaseTable.Controls.Count == 2)
                    {
                        materialBaseTable.Controls.RemoveAt(1);
                    }
                   materialBaseTable.Controls.Add(alumPanel, 1, 0);
                    break;
                case "amarante":
                    if (materialBaseTable.Controls.Count == 2)
                    {
                        materialBaseTable.Controls.RemoveAt(1);
                    }
                    materialBaseTable.Controls.Add(amarantePanel, 1, 0);
                    break;
                case "coffrage":
                    if (materialBaseTable.Controls.Count == 2)
                    {
                        materialBaseTable.Controls.RemoveAt(1);
                    }
                    materialBaseTable.Controls.Add(coffragePanel, 1, 0);
                    break;
                default:
                    break;
            }
        }

        private void openGLControl1_OpenGLDraw(object sender, SharpGL.RenderEventArgs args)
        {
            //  Get the OpenGL object, for quick access.

            SharpGL.OpenGL gl = this.openGLControl1.OpenGL;

            gl.Clear(SharpGL.OpenGL.GL_COLOR_BUFFER_BIT | SharpGL.OpenGL.GL_DEPTH_BUFFER_BIT);

            gl.LoadIdentity();

            gl.Translate(0.0f, 0.0f, -6.0f);

            gl.Rotate(rtri1, -0.5f, 1.0f, 0.0f);

            gl.BindTexture(SharpGL.OpenGL.GL_TEXTURE_2D, textures1[0]);

            gl.Begin(SharpGL.OpenGL.GL_QUADS);



            // Front Face

            gl.TexCoord(0.0f, 0.0f); gl.Vertex(-1.0f, -1.0f, 1.0f); // Bottom Left Of The Texture and Quad

            gl.TexCoord(1.0f, 0.0f); gl.Vertex(1.0f, -1.0f, 1.0f);  // Bottom Right Of The Texture and Quad

            gl.TexCoord(1.0f, 1.0f); gl.Vertex(1.0f, 1.0f, 1.0f);   // Top Right Of The Texture and Quad

            gl.TexCoord(0.0f, 1.0f); gl.Vertex(-1.0f, 1.0f, 1.0f);  // Top Left Of The Texture and Quad



            // Back Face

            gl.TexCoord(1.0f, 0.0f); gl.Vertex(-1.0f, -1.0f, -1.0f);    // Bottom Right Of The Texture and Quad

            gl.TexCoord(1.0f, 1.0f); gl.Vertex(-1.0f, 1.0f, -1.0f); // Top Right Of The Texture and Quad

            gl.TexCoord(0.0f, 1.0f); gl.Vertex(1.0f, 1.0f, -1.0f);  // Top Left Of The Texture and Quad

            gl.TexCoord(0.0f, 0.0f); gl.Vertex(1.0f, -1.0f, -1.0f); // Bottom Left Of The Texture and Quad



            // Top Face

            gl.TexCoord(0.0f, 1.0f); gl.Vertex(-1.0f, 1.0f, -1.0f); // Top Left Of The Texture and Quad

            gl.TexCoord(0.0f, 0.0f); gl.Vertex(-1.0f, 1.0f, 1.0f);  // Bottom Left Of The Texture and Quad

            gl.TexCoord(1.0f, 0.0f); gl.Vertex(1.0f, 1.0f, 1.0f);   // Bottom Right Of The Texture and Quad

            gl.TexCoord(1.0f, 1.0f); gl.Vertex(1.0f, 1.0f, -1.0f);  // Top Right Of The Texture and Quad



            // Bottom Face

            gl.TexCoord(1.0f, 1.0f); gl.Vertex(-1.0f, -1.0f, -1.0f);    // Top Right Of The Texture and Quad

            gl.TexCoord(0.0f, 1.0f); gl.Vertex(1.0f, -1.0f, -1.0f); // Top Left Of The Texture and Quad

            gl.TexCoord(0.0f, 0.0f); gl.Vertex(1.0f, -1.0f, 1.0f);  // Bottom Left Of The Texture and Quad

            gl.TexCoord(1.0f, 0.0f); gl.Vertex(-1.0f, -1.0f, 1.0f); // Bottom Right Of The Texture and Quad



            // Right face

            gl.TexCoord(1.0f, 0.0f); gl.Vertex(1.0f, -1.0f, -1.0f); // Bottom Right Of The Texture and Quad

            gl.TexCoord(1.0f, 1.0f); gl.Vertex(1.0f, 1.0f, -1.0f);  // Top Right Of The Texture and Quad

            gl.TexCoord(0.0f, 1.0f); gl.Vertex(1.0f, 1.0f, 1.0f);   // Top Left Of The Texture and Quad

            gl.TexCoord(0.0f, 0.0f); gl.Vertex(1.0f, -1.0f, 1.0f);  // Bottom Left Of The Texture and Quad



            // Left Face

            gl.TexCoord(0.0f, 0.0f); gl.Vertex(-1.0f, -1.0f, -1.0f);    // Bottom Left Of The Texture and Quad

            gl.TexCoord(1.0f, 0.0f); gl.Vertex(-1.0f, -1.0f, 1.0f); // Bottom Right Of The Texture and Quad

            gl.TexCoord(1.0f, 1.0f); gl.Vertex(-1.0f, 1.0f, 1.0f);  // Top Right Of The Texture and Quad

            gl.TexCoord(0.0f, 1.0f); gl.Vertex(-1.0f, 1.0f, -1.0f);	// Top Left Of The Texture and Quad

            gl.End();

            gl.Flush();

            rtri1 += 1.0f;// 0.2f;						// Increase The Rotation Variable For The Triangle 
        }

        private void openGLControl1_OpenGLInitialized(object sender, EventArgs e)
        {
            //  Get the OpenGL object, for quick access.

            SharpGL.OpenGL gl = this.openGLControl1.OpenGL;



            //  We need to load the texture from file.
            textureImage1 = new Bitmap(Properties.Resources.Crate);

            //  A bit of extra initialisation here, we have to enable textures.
            gl.Enable(SharpGL.OpenGL.GL_TEXTURE_2D);


            //  Get one texture id, and stick it into the textures array.
            gl.GenTextures(1, textures1);



            //  Bind the texture.

            gl.BindTexture(SharpGL.OpenGL.GL_TEXTURE_2D, textures1[0]);



            //  Tell OpenGL where the texture data is.

            gl.TexImage2D(SharpGL.OpenGL.GL_TEXTURE_2D, 0, 3, textureImage1.Width, textureImage1.Height, 0, SharpGL.OpenGL.GL_BGR, SharpGL.OpenGL.GL_UNSIGNED_BYTE,

                textureImage1.LockBits(new Rectangle(0, 0, textureImage1.Width, textureImage1.Height),

                ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb).Scan0);



            //  Specify linear filtering.

            gl.TexParameter(SharpGL.OpenGL.GL_TEXTURE_2D, SharpGL.OpenGL.GL_TEXTURE_MIN_FILTER, SharpGL.OpenGL.GL_LINEAR);

            gl.TexParameter(SharpGL.OpenGL.GL_TEXTURE_2D, SharpGL.OpenGL.GL_TEXTURE_MAG_FILTER, SharpGL.OpenGL.GL_LINEAR);

        }


        private void openGLControl2_OpenGLDraw(object sender, SharpGL.RenderEventArgs args)
        {
            //  Get the OpenGL object, for quick access.

            SharpGL.OpenGL gl = this.openGLControl2.OpenGL;

            gl.Clear(SharpGL.OpenGL.GL_COLOR_BUFFER_BIT | SharpGL.OpenGL.GL_DEPTH_BUFFER_BIT);

            gl.LoadIdentity();

            gl.Translate(0.0f, 0.0f, -6.0f);

            gl.Rotate(rtri, -0.5f, 1.0f, 0.0f);


            gl.BindTexture(SharpGL.OpenGL.GL_TEXTURE_2D, textures[0]);

            gl.Begin(SharpGL.OpenGL.GL_QUADS);



            // Front Face

            gl.TexCoord(0.0f, 0.0f); gl.Vertex(-1.0f, -1.0f, 1.0f); // Bottom Left Of The Texture and Quad

            gl.TexCoord(1.0f, 0.0f); gl.Vertex(1.0f, -1.0f, 1.0f);  // Bottom Right Of The Texture and Quad

            gl.TexCoord(1.0f, 1.0f); gl.Vertex(1.0f, 1.0f, 1.0f);   // Top Right Of The Texture and Quad

            gl.TexCoord(0.0f, 1.0f); gl.Vertex(-1.0f, 1.0f, 1.0f);  // Top Left Of The Texture and Quad



            // Back Face

            gl.TexCoord(1.0f, 0.0f); gl.Vertex(-1.0f, -1.0f, -1.0f);    // Bottom Right Of The Texture and Quad

            gl.TexCoord(1.0f, 1.0f); gl.Vertex(-1.0f, 1.0f, -1.0f); // Top Right Of The Texture and Quad

            gl.TexCoord(0.0f, 1.0f); gl.Vertex(1.0f, 1.0f, -1.0f);  // Top Left Of The Texture and Quad

            gl.TexCoord(0.0f, 0.0f); gl.Vertex(1.0f, -1.0f, -1.0f); // Bottom Left Of The Texture and Quad



            // Top Face

            gl.TexCoord(0.0f, 1.0f); gl.Vertex(-1.0f, 1.0f, -1.0f); // Top Left Of The Texture and Quad

            gl.TexCoord(0.0f, 0.0f); gl.Vertex(-1.0f, 1.0f, 1.0f);  // Bottom Left Of The Texture and Quad

            gl.TexCoord(1.0f, 0.0f); gl.Vertex(1.0f, 1.0f, 1.0f);   // Bottom Right Of The Texture and Quad

            gl.TexCoord(1.0f, 1.0f); gl.Vertex(1.0f, 1.0f, -1.0f);  // Top Right Of The Texture and Quad



            // Bottom Face

            gl.TexCoord(1.0f, 1.0f); gl.Vertex(-1.0f, -1.0f, -1.0f);    // Top Right Of The Texture and Quad

            gl.TexCoord(0.0f, 1.0f); gl.Vertex(1.0f, -1.0f, -1.0f); // Top Left Of The Texture and Quad

            gl.TexCoord(0.0f, 0.0f); gl.Vertex(1.0f, -1.0f, 1.0f);  // Bottom Left Of The Texture and Quad

            gl.TexCoord(1.0f, 0.0f); gl.Vertex(-1.0f, -1.0f, 1.0f); // Bottom Right Of The Texture and Quad



            // Right face

            gl.TexCoord(1.0f, 0.0f); gl.Vertex(1.0f, -1.0f, -1.0f); // Bottom Right Of The Texture and Quad

            gl.TexCoord(1.0f, 1.0f); gl.Vertex(1.0f, 1.0f, -1.0f);  // Top Right Of The Texture and Quad

            gl.TexCoord(0.0f, 1.0f); gl.Vertex(1.0f, 1.0f, 1.0f);   // Top Left Of The Texture and Quad

            gl.TexCoord(0.0f, 0.0f); gl.Vertex(1.0f, -1.0f, 1.0f);  // Bottom Left Of The Texture and Quad



            // Left Face

            gl.TexCoord(0.0f, 0.0f); gl.Vertex(-1.0f, -1.0f, -1.0f);    // Bottom Left Of The Texture and Quad

            gl.TexCoord(1.0f, 0.0f); gl.Vertex(-1.0f, -1.0f, 1.0f); // Bottom Right Of The Texture and Quad

            gl.TexCoord(1.0f, 1.0f); gl.Vertex(-1.0f, 1.0f, 1.0f);  // Top Right Of The Texture and Quad

            gl.TexCoord(0.0f, 1.0f); gl.Vertex(-1.0f, 1.0f, -1.0f);	// Top Left Of The Texture and Quad

            gl.End();



            gl.Flush();



            rtri += 1.0f;// 0.2f;						// Increase The Rotation Variable For The Triangle 
        }

        private void openGLControl2_OpenGLInitialized(object sender, EventArgs e)
        {
            //  Get the OpenGL object, for quick access.

            SharpGL.OpenGL gl = this.openGLControl2.OpenGL;



            //  We need to load the texture from file.
            textureImage = new Bitmap(Properties.Resources.Crate);

            //  A bit of extra initialisation here, we have to enable textures.
            gl.Enable(SharpGL.OpenGL.GL_TEXTURE_2D);


            //  Get one texture id, and stick it into the textures array.
            gl.GenTextures(1, textures);



            //  Bind the texture.

            gl.BindTexture(SharpGL.OpenGL.GL_TEXTURE_2D, textures[0]);



            //  Tell OpenGL where the texture data is.

            gl.TexImage2D(SharpGL.OpenGL.GL_TEXTURE_2D, 0, 3, textureImage.Width, textureImage.Height, 0, SharpGL.OpenGL.GL_BGR, SharpGL.OpenGL.GL_UNSIGNED_BYTE,

                textureImage.LockBits(new Rectangle(0, 0, textureImage.Width, textureImage.Height),

                ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb).Scan0);



            //  Specify linear filtering.

            gl.TexParameter(SharpGL.OpenGL.GL_TEXTURE_2D, SharpGL.OpenGL.GL_TEXTURE_MIN_FILTER, SharpGL.OpenGL.GL_LINEAR);

            gl.TexParameter(SharpGL.OpenGL.GL_TEXTURE_2D, SharpGL.OpenGL.GL_TEXTURE_MAG_FILTER, SharpGL.OpenGL.GL_LINEAR);
        }



        private void openGLControl3_OpenGLDraw(object sender, SharpGL.RenderEventArgs args)
        {
            //  Get the OpenGL object, for quick access.

            SharpGL.OpenGL gl = this.openGLControl3.OpenGL;

            gl.Clear(SharpGL.OpenGL.GL_COLOR_BUFFER_BIT | SharpGL.OpenGL.GL_DEPTH_BUFFER_BIT);

            gl.LoadIdentity();

            gl.Translate(0.0f, 0.0f, -6.0f);

            gl.Rotate(rtri, -0.5f, 1.0f, 0.0f);


            gl.BindTexture(SharpGL.OpenGL.GL_TEXTURE_2D, textures[0]);

            gl.Begin(SharpGL.OpenGL.GL_QUADS);

            // Front Face

            gl.TexCoord(0.0f, 0.0f); gl.Vertex(-1.0f, -1.0f, 1.0f); // Bottom Left Of The Texture and Quad

            gl.TexCoord(1.0f, 0.0f); gl.Vertex(1.0f, -1.0f, 1.0f);  // Bottom Right Of The Texture and Quad

            gl.TexCoord(1.0f, 1.0f); gl.Vertex(1.0f, 1.0f, 1.0f);   // Top Right Of The Texture and Quad

            gl.TexCoord(0.0f, 1.0f); gl.Vertex(-1.0f, 1.0f, 1.0f);  // Top Left Of The Texture and Quad



            // Back Face

            gl.TexCoord(1.0f, 0.0f); gl.Vertex(-1.0f, -1.0f, -1.0f);    // Bottom Right Of The Texture and Quad

            gl.TexCoord(1.0f, 1.0f); gl.Vertex(-1.0f, 1.0f, -1.0f); // Top Right Of The Texture and Quad

            gl.TexCoord(0.0f, 1.0f); gl.Vertex(1.0f, 1.0f, -1.0f);  // Top Left Of The Texture and Quad

            gl.TexCoord(0.0f, 0.0f); gl.Vertex(1.0f, -1.0f, -1.0f); // Bottom Left Of The Texture and Quad



            // Top Face

            gl.TexCoord(0.0f, 1.0f); gl.Vertex(-1.0f, 1.0f, -1.0f); // Top Left Of The Texture and Quad

            gl.TexCoord(0.0f, 0.0f); gl.Vertex(-1.0f, 1.0f, 1.0f);  // Bottom Left Of The Texture and Quad

            gl.TexCoord(1.0f, 0.0f); gl.Vertex(1.0f, 1.0f, 1.0f);   // Bottom Right Of The Texture and Quad

            gl.TexCoord(1.0f, 1.0f); gl.Vertex(1.0f, 1.0f, -1.0f);  // Top Right Of The Texture and Quad



            // Bottom Face

            gl.TexCoord(1.0f, 1.0f); gl.Vertex(-1.0f, -1.0f, -1.0f);    // Top Right Of The Texture and Quad

            gl.TexCoord(0.0f, 1.0f); gl.Vertex(1.0f, -1.0f, -1.0f); // Top Left Of The Texture and Quad

            gl.TexCoord(0.0f, 0.0f); gl.Vertex(1.0f, -1.0f, 1.0f);  // Bottom Left Of The Texture and Quad

            gl.TexCoord(1.0f, 0.0f); gl.Vertex(-1.0f, -1.0f, 1.0f); // Bottom Right Of The Texture and Quad



            // Right face

            gl.TexCoord(1.0f, 0.0f); gl.Vertex(1.0f, -1.0f, -1.0f); // Bottom Right Of The Texture and Quad

            gl.TexCoord(1.0f, 1.0f); gl.Vertex(1.0f, 1.0f, -1.0f);  // Top Right Of The Texture and Quad

            gl.TexCoord(0.0f, 1.0f); gl.Vertex(1.0f, 1.0f, 1.0f);   // Top Left Of The Texture and Quad

            gl.TexCoord(0.0f, 0.0f); gl.Vertex(1.0f, -1.0f, 1.0f);  // Bottom Left Of The Texture and Quad



            // Left Face

            gl.TexCoord(0.0f, 0.0f); gl.Vertex(-1.0f, -1.0f, -1.0f);    // Bottom Left Of The Texture and Quad

            gl.TexCoord(1.0f, 0.0f); gl.Vertex(-1.0f, -1.0f, 1.0f); // Bottom Right Of The Texture and Quad

            gl.TexCoord(1.0f, 1.0f); gl.Vertex(-1.0f, 1.0f, 1.0f);  // Top Right Of The Texture and Quad

            gl.TexCoord(0.0f, 1.0f); gl.Vertex(-1.0f, 1.0f, -1.0f);	// Top Left Of The Texture and Quad

            gl.End();



            gl.Flush();



            rtri += 1.0f;// 0.2f;						// Increase The Rotation Variable For The Triangle 
        }

        private void openGLControl3_OpenGLInitialized(object sender, EventArgs e)
        {
            //  Get the OpenGL object, for quick access.

            SharpGL.OpenGL gl = this.openGLControl3.OpenGL;



            //  We need to load the texture from file.
            textureImage = new Bitmap(Properties.Resources.pine1);

            //  A bit of extra initialisation here, we have to enable textures.
            gl.Enable(SharpGL.OpenGL.GL_TEXTURE_2D);


            //  Get one texture id, and stick it into the textures array.
            gl.GenTextures(1, textures);



            //  Bind the texture.

            gl.BindTexture(SharpGL.OpenGL.GL_TEXTURE_2D, textures[0]);



            //  Tell OpenGL where the texture data is.

            gl.TexImage2D(SharpGL.OpenGL.GL_TEXTURE_2D, 0, 3, textureImage.Width, textureImage.Height, 0, SharpGL.OpenGL.GL_BGR, SharpGL.OpenGL.GL_UNSIGNED_BYTE,

                textureImage.LockBits(new Rectangle(0, 0, textureImage.Width, textureImage.Height),

                ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb).Scan0);



            //  Specify linear filtering.

            gl.TexParameter(SharpGL.OpenGL.GL_TEXTURE_2D, SharpGL.OpenGL.GL_TEXTURE_MIN_FILTER, SharpGL.OpenGL.GL_LINEAR);

            gl.TexParameter(SharpGL.OpenGL.GL_TEXTURE_2D, SharpGL.OpenGL.GL_TEXTURE_MAG_FILTER, SharpGL.OpenGL.GL_LINEAR);
        }

        private void openGLControl4_OpenGLDraw(object sender, SharpGL.RenderEventArgs args)
        {
            //  Get the OpenGL object, for quick access.

            SharpGL.OpenGL gl = this.openGLControl4.OpenGL;

            gl.Clear(SharpGL.OpenGL.GL_COLOR_BUFFER_BIT | SharpGL.OpenGL.GL_DEPTH_BUFFER_BIT);

            gl.LoadIdentity();

            gl.Translate(0.0f, 0.0f, -6.0f);

            gl.Rotate(rtri3, -0.5f, 1.0f, 0.0f);


            gl.BindTexture(SharpGL.OpenGL.GL_TEXTURE_2D, textures3[0]);

            gl.Begin(SharpGL.OpenGL.GL_QUADS);



            // Front Face

            gl.TexCoord(0.0f, 0.0f); gl.Vertex(-1.0f, -1.0f, 1.0f); // Bottom Left Of The Texture and Quad

            gl.TexCoord(1.0f, 0.0f); gl.Vertex(1.0f, -1.0f, 1.0f);  // Bottom Right Of The Texture and Quad

            gl.TexCoord(1.0f, 1.0f); gl.Vertex(1.0f, 1.0f, 1.0f);   // Top Right Of The Texture and Quad

            gl.TexCoord(0.0f, 1.0f); gl.Vertex(-1.0f, 1.0f, 1.0f);  // Top Left Of The Texture and Quad



            // Back Face

            gl.TexCoord(1.0f, 0.0f); gl.Vertex(-1.0f, -1.0f, -1.0f);    // Bottom Right Of The Texture and Quad

            gl.TexCoord(1.0f, 1.0f); gl.Vertex(-1.0f, 1.0f, -1.0f); // Top Right Of The Texture and Quad

            gl.TexCoord(0.0f, 1.0f); gl.Vertex(1.0f, 1.0f, -1.0f);  // Top Left Of The Texture and Quad

            gl.TexCoord(0.0f, 0.0f); gl.Vertex(1.0f, -1.0f, -1.0f); // Bottom Left Of The Texture and Quad



            // Top Face

            gl.TexCoord(0.0f, 1.0f); gl.Vertex(-1.0f, 1.0f, -1.0f); // Top Left Of The Texture and Quad

            gl.TexCoord(0.0f, 0.0f); gl.Vertex(-1.0f, 1.0f, 1.0f);  // Bottom Left Of The Texture and Quad

            gl.TexCoord(1.0f, 0.0f); gl.Vertex(1.0f, 1.0f, 1.0f);   // Bottom Right Of The Texture and Quad

            gl.TexCoord(1.0f, 1.0f); gl.Vertex(1.0f, 1.0f, -1.0f);  // Top Right Of The Texture and Quad



            // Bottom Face

            gl.TexCoord(1.0f, 1.0f); gl.Vertex(-1.0f, -1.0f, -1.0f);    // Top Right Of The Texture and Quad

            gl.TexCoord(0.0f, 1.0f); gl.Vertex(1.0f, -1.0f, -1.0f); // Top Left Of The Texture and Quad

            gl.TexCoord(0.0f, 0.0f); gl.Vertex(1.0f, -1.0f, 1.0f);  // Bottom Left Of The Texture and Quad

            gl.TexCoord(1.0f, 0.0f); gl.Vertex(-1.0f, -1.0f, 1.0f); // Bottom Right Of The Texture and Quad



            // Right face

            gl.TexCoord(1.0f, 0.0f); gl.Vertex(1.0f, -1.0f, -1.0f); // Bottom Right Of The Texture and Quad

            gl.TexCoord(1.0f, 1.0f); gl.Vertex(1.0f, 1.0f, -1.0f);  // Top Right Of The Texture and Quad

            gl.TexCoord(0.0f, 1.0f); gl.Vertex(1.0f, 1.0f, 1.0f);   // Top Left Of The Texture and Quad

            gl.TexCoord(0.0f, 0.0f); gl.Vertex(1.0f, -1.0f, 1.0f);  // Bottom Left Of The Texture and Quad



            // Left Face

            gl.TexCoord(0.0f, 0.0f); gl.Vertex(-1.0f, -1.0f, -1.0f);    // Bottom Left Of The Texture and Quad

            gl.TexCoord(1.0f, 0.0f); gl.Vertex(-1.0f, -1.0f, 1.0f); // Bottom Right Of The Texture and Quad

            gl.TexCoord(1.0f, 1.0f); gl.Vertex(-1.0f, 1.0f, 1.0f);  // Top Right Of The Texture and Quad

            gl.TexCoord(0.0f, 1.0f); gl.Vertex(-1.0f, 1.0f, -1.0f);	// Top Left Of The Texture and Quad

            gl.End();



            gl.Flush();



            rtri3 += 1.0f;// 0.2f;						// Increase The Rotation Variable For The Triangle 
        }

        private void openGLControl4_OpenGLInitialized(object sender, EventArgs e)
        {
            //  Get the OpenGL object, for quick access.

            SharpGL.OpenGL gl = this.openGLControl4.OpenGL;



            //  We need to load the texture from file.
            textureImage3 = new Bitmap(Properties.Resources.Crate);

            //  A bit of extra initialisation here, we have to enable textures.
            gl.Enable(SharpGL.OpenGL.GL_TEXTURE_2D);


            //  Get one texture id, and stick it into the textures array.
            gl.GenTextures(1, textures3);



            //  Bind the texture.

            gl.BindTexture(SharpGL.OpenGL.GL_TEXTURE_2D, textures3[0]);



            //  Tell OpenGL where the texture data is.

            gl.TexImage2D(SharpGL.OpenGL.GL_TEXTURE_2D, 0, 3, textureImage3.Width, textureImage3.Height, 0, SharpGL.OpenGL.GL_BGR, SharpGL.OpenGL.GL_UNSIGNED_BYTE,

                textureImage3.LockBits(new Rectangle(0, 0, textureImage3.Width, textureImage3.Height),

                ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb).Scan0);



            //  Specify linear filtering.

            gl.TexParameter(SharpGL.OpenGL.GL_TEXTURE_2D, SharpGL.OpenGL.GL_TEXTURE_MIN_FILTER, SharpGL.OpenGL.GL_LINEAR);

            gl.TexParameter(SharpGL.OpenGL.GL_TEXTURE_2D, SharpGL.OpenGL.GL_TEXTURE_MAG_FILTER, SharpGL.OpenGL.GL_LINEAR);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
    }
   
}
