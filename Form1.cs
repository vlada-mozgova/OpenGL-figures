using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpGL;
// для работы с библиотекой OpenGL 
using Tao.OpenGl;
// для работы с библиотекой FreeGLUT 
using Tao.FreeGlut;
// для работы с элементом управления SimpleOpenGLControl 
using Tao.Platform.Windows;
using Tao.DevIl;

namespace KGV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // инициализация Glut 
            Glut.glutInit(); 
            Glut.glutInitDisplayMode(Glut.GLUT_RGB | Glut.GLUT_DOUBLE | Glut.GLUT_DEPTH);
        }
        private void Lighting(float[] mtClr, float[] lghtClr)
        {
            float[] light_position = { 0.5f, 0.5f, 0.5f, 1.0f }; // Координаты источника света
            //float[] lghtClr - Источник излучает цвет
            Gl.glPolygonMode(Gl.GL_FRONT, Gl.GL_FILL); // Заливка полигонов
            Gl.glShadeModel(Gl.GL_SMOOTH); // Вывод с интерполяцией цветов
            Gl.glEnable(Gl.GL_LIGHTING); // Будем рассчитывать освещенность
            Gl.glLightfv(Gl.GL_LIGHT0, Gl.GL_POSITION, light_position);
            Gl.glLightfv(Gl.GL_LIGHT0, Gl.GL_AMBIENT, lghtClr); // Рассеивание
            Gl.glEnable(Gl.GL_LIGHT0); // Включаем в уравнение освещенности источник GL_LIGHT0
            //float[] mtClr - Материал заданного цвета
            Gl.glMaterialfv(Gl.GL_FRONT, Gl.GL_DIFFUSE, mtClr);
        }
        private void GlutRotation()
        {
            Gl.glTranslated(trackBarTransX.Value, trackBarTransY.Value, trackBarTransZ.Value);

            if (checkBoxRotationX.Checked)
            {
                if (trackBarRotationX.Value + 1 > 1080)
                    trackBarRotationX.Value = -1080;
                Gl.glRotated((trackBarRotationX.Value += 1)/3.0, 1.0f, 0.0f, 0.0f);
            }
            else
                Gl.glRotated(trackBarRotationX.Value/3.0, 1.0f, 0.0f, 0.0f);
            if (checkBoxRotationY.Checked)
            {
                if (trackBarRotationY.Value + 1 > 1080)
                    trackBarRotationY.Value = -1080;
                Gl.glRotated((trackBarRotationY.Value += 1) / 3.0, 0.0f, 1.0f, 0.0f);
            }
            else
                Gl.glRotated(trackBarRotationY.Value / 3.0, 0.0f, 1.0f, 0.0f);
            if (checkBoxRotationZ.Checked)
            {
                if (trackBarRotationZ.Value + 1 > 1080)
                    trackBarRotationZ.Value = -1080;
                Gl.glRotated((trackBarRotationZ.Value += 1) / 3.0, 0.0f, 0.0f, 1.0f);
            }
            else
                Gl.glRotated(trackBarRotationZ.Value / 3.0, 0.0f, 0.0f, 1.0f);
        }
        private void Rotation(OpenGL gl)
        {
            gl.Translate(trackBarTransX.Value, trackBarTransY.Value, trackBarTransZ.Value);

            if (checkBoxRotationX.Checked)
            {
                if (trackBarRotationX.Value + 1 > 1080)
                    trackBarRotationX.Value = -1080;
                gl.Rotate((trackBarRotationX.Value += 1) / 3.0, 1.0f, 0.0f, 0.0f);
            }
            else
                gl.Rotate(trackBarRotationX.Value / 3.0, 1.0f, 0.0f, 0.0f);
            if (checkBoxRotationY.Checked)
            {
                if (trackBarRotationY.Value + 1 > 1080)
                    trackBarRotationY.Value = -1080;
                gl.Rotate((trackBarRotationY.Value += 1) / 3.0, 0.0f, 1.0f, 0.0f);
            }
            else
                gl.Rotate(trackBarRotationY.Value / 3.0, 0.0f, 1.0f, 0.0f);
            if (checkBoxRotationZ.Checked)
            {
                if (trackBarRotationZ.Value + 1 > 1080)
                    trackBarRotationZ.Value = -1080;
                gl.Rotate((trackBarRotationZ.Value += 1) / 3.0, 0.0f, 0.0f, 1.0f);
            }
            else
                gl.Rotate(trackBarRotationZ.Value / 3.0, 0.0f, 0.0f, 1.0f);
        }
        private void DrawLetterZ()
        {
            Gl.glDisable(Gl.GL_LIGHT0);
            Gl.glDisable(Gl.GL_LIGHTING);
            // Очистка экрана и буфера глубин
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            // очищаем текущую матрицу 
            Gl.glLoadIdentity();
            // активируем режим рисования линий, на основе 
            // последовательного соединения всех вершин в отрезки 
            //Gl.glTranslated(-0.3f, -0.2f, -0.4f);
            Gl.glTranslated(-0.4f, -0.4f, -2.0f);

            Gl.glEnable(Gl.GL_LINE_SMOOTH);
            Gl.glHint(Gl.GL_LINE_SMOOTH_HINT, Gl.GL_NICEST);
            Gl.glEnable(Gl.GL_POINT_SMOOTH);
            Gl.glHint(Gl.GL_POINT_SMOOTH_HINT, Gl.GL_NICEST);
            Gl.glEnable(Gl.GL_BLEND);
            Gl.glBlendFunc(Gl.GL_SRC_ALPHA, Gl.GL_ONE_MINUS_SRC_ALPHA);

            Gl.glLineWidth(2.0f);
            Gl.glBegin(Gl.GL_LINES);

            // устанавливаем текущий цвет - красный 
            Gl.glColor3f(1, 0, 0);
            Gl.glVertex2f(1.0f / 20.0f, 20.0f / 20.0f);
            Gl.glVertex2f(15.0f / 20.0f, 20.0f / 20.0f);

            Gl.glVertex2f(15.0f / 20.0f, 20.0f / 20.0f);
            Gl.glVertex2f(15.0f / 20.0f, 17.0f / 20.0f);

            Gl.glVertex2f(15.0f / 20.0f, 17.0f / 20.0f);
            Gl.glVertex2f(5.0f / 20.0f, 4.0f / 20.0f);

            Gl.glVertex2f(5.0f / 20.0f, 4.0f / 20.0f);
            Gl.glVertex2f(15.0f / 20.0f, 4.0f / 20.0f);

            Gl.glVertex2f(15.0f / 20.0f, 4.0f / 20.0f);
            Gl.glVertex2f(15.0f / 20.0f, 1.0f / 20.0f);

            Gl.glVertex2f(15.0f / 20.0f, 1.0f / 20.0f);
            Gl.glVertex2f(1.0f / 20.0f, 1.0f / 20.0f);

            Gl.glVertex2f(1.0f / 20.0f, 1.0f / 20.0f);
            Gl.glVertex2f(1.0f / 20.0f, 4.0f / 20.0f);

            Gl.glVertex2f(1.0f / 20.0f, 4.0f / 20.0f);
            Gl.glVertex2f(11.0f / 20.0f, 17.0f / 20.0f);

            Gl.glVertex2f(11.0f / 20.0f, 17.0f / 20.0f);
            Gl.glVertex2f(1.0f / 20.0f, 17.0f / 20.0f);

            Gl.glVertex2f(1.0f / 20.0f, 17.0f / 20.0f);
            Gl.glVertex2f(1.0f / 20.0f, 20.0f / 20.0f);

            //завершаем режим рисования
            Gl.glEnd();
            // дожидаемся конца визуализации кадра 
            Gl.glFlush();
        }
        private void DrawLetterA()
        {
            Gl.glDisable(Gl.GL_LIGHT0);
            Gl.glDisable(Gl.GL_LIGHTING);
            // Очистка экрана и буфера глубин
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glLoadIdentity();
            Gl.glTranslated(-0.6f, -0.6f, -1f);

            Gl.glEnable(Gl.GL_LINE_SMOOTH);
            Gl.glHint(Gl.GL_LINE_SMOOTH_HINT, Gl.GL_NICEST);
            Gl.glEnable(Gl.GL_POINT_SMOOTH);
            Gl.glHint(Gl.GL_POINT_SMOOTH_HINT, Gl.GL_NICEST);
            Gl.glEnable(Gl.GL_BLEND);
            Gl.glBlendFunc(Gl.GL_SRC_ALPHA, Gl.GL_ONE_MINUS_SRC_ALPHA);

            Gl.glLineWidth(2.0f);
            Gl.glBegin(Gl.GL_LINES);  

            Gl.glColor3f(1.0f, 0.0f, 0.0f);
            Gl.glVertex2f(8 / 27f, 7 / 27f);
            Gl.glVertex2f(15 / 27f, 27f / 27f);
            Gl.glVertex2f(15 / 27f, 27f / 27f);
            Gl.glVertex2f(17f / 27f, 27f / 27f);
            Gl.glVertex2f(17f / 27f, 27f / 27f);
            Gl.glVertex2f(23 / 27f, 7f / 27f);
            Gl.glVertex2f(23 / 27f, 7 / 27f);
            Gl.glVertex2f(21 / 27f, 7 / 27f);
            Gl.glVertex2f(21 / 27f, 7 / 27f);
            Gl.glVertex2f(19 / 27f, 14 / 27f);
            Gl.glVertex2f(19 / 27f, 14 / 27f);
            Gl.glVertex2f(12.5f / 27f, 14 / 27f);
            Gl.glVertex2f(12.5f / 27f, 14 / 27f);
            Gl.glVertex2f(10 / 27f, 7 / 27f);
            Gl.glVertex2f(10 / 27f, 7 / 27f);
            Gl.glVertex2f(8 / 27f, 7 / 27f);

            Gl.glVertex2f(13.2f / 27f, 16 / 27f);
            Gl.glVertex2f(16 / 27f, 25 / 27f);
            Gl.glVertex2f(16 / 27f, 25 / 27f);
            Gl.glVertex2f(18.5f / 27f, 16 / 27f);
            Gl.glVertex2f(18.5f / 27f, 16 / 27f);
            Gl.glVertex2f(13.2f / 27f, 16 / 27f);

            Gl.glEnd();
            Gl.glFlush();
        }
        private void DrawSphere()
        {
            Gl.glDisable(Gl.GL_BLEND);

            Gl.glColor3f(1, 0, 1);

            Gl.glPushMatrix();

            GlutRotation();

            // рисуем сферу с помощью библиотеки FreeGLUT 
            if (checkBoxType.Checked) Glut.glutWireSphere(2, 32, 32);
            else Glut.glutSolidSphere(2, 32, 32);

            Gl.glPopMatrix();
            Gl.glDisable(Gl.GL_LIGHTING); // Будем рассчитывать освещенность
            Gl.glFlush();
        }
        private void DrawCube(OpenGL cube)
        {
            cube.Disable(OpenGL.GL_LIGHT0);
            cube.Disable(OpenGL.GL_LIGHTING);
            cube.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
            cube.LoadIdentity();
            Rotation(cube);
            
            cube.Begin(OpenGL.GL_QUADS);

            cube.Color(0.0f, 1.0f, 0.0f);
            cube.Vertex(1.0f, 1.0f, -1.0f);
            cube.Vertex(-1.0f, 1.0f, -1.0f);
            cube.Vertex(-1.0f, 1.0f, 1.0f);
            cube.Vertex(1.0f, 1.0f, 1.0f);
            // Bottom

            cube.Color(1.0f, 0.5f, 0.0f);
            cube.Vertex(1.0f, -1.0f, 1.0f);
            cube.Vertex(-1.0f, -1.0f, 1.0f);
            cube.Vertex(-1.0f, -1.0f, -1.0f);
            cube.Vertex(1.0f, -1.0f, -1.0f);
            // Front
            cube.Color(1.0f, 0.0f, 0.0f);
            cube.Vertex(1.0f, 1.0f, 1.0f);
            cube.Vertex(-1.0f, 1.0f, 1.0f);
            cube.Vertex(-1.0f, -1.0f, 1.0f);
            cube.Vertex(1.0f, -1.0f, 1.0f);
            // Back
            cube.Color(1.0f, 1.0f, 0.0f);
            cube.Vertex(1.0f, -1.0f, -1.0f);
            cube.Vertex(-1.0f, -1.0f, -1.0f);
            cube.Vertex(-1.0f, 1.0f, -1.0f);
            cube.Vertex(1.0f, 1.0f, -1.0f);
            // Left
            cube.Color(0.0f, 0.0f, 1.0f);
            cube.Vertex(-1.0f, 1.0f, 1.0f);
            cube.Vertex(-1.0f, 1.0f, -1.0f);
            cube.Vertex(-1.0f, -1.0f, -1.0f);
            cube.Vertex(-1.0f, -1.0f, 1.0f);
            // Right
            cube.Color(1.0f, 0.0f, 1.0f);
            cube.Vertex(1.0f, 1.0f, -1.0f);
            cube.Vertex(1.0f, 1.0f, 1.0f);
            cube.Vertex(1.0f, -1.0f, 1.0f);
            cube.Vertex(1.0f, -1.0f, -1.0f);
            cube.End();
            // Контроль полной отрисовки следующего изображения
            cube.Flush();
        }
        private void DrawRectangle()
        {
            Gl.glDisable(Gl.GL_LIGHT0);
            Gl.glDisable(Gl.GL_LIGHTING);
            // Очистка экрана и буфера глубин
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glLoadIdentity();

            GlutRotation();

            Gl.glEnable(Gl.GL_LINE_SMOOTH);
            Gl.glHint(Gl.GL_LINE_SMOOTH_HINT, Gl.GL_NICEST);
            Gl.glEnable(Gl.GL_POINT_SMOOTH);
            Gl.glHint(Gl.GL_POINT_SMOOTH_HINT, Gl.GL_NICEST);
            Gl.glEnable(Gl.GL_BLEND);
            Gl.glBlendFunc(Gl.GL_SRC_ALPHA, Gl.GL_ONE_MINUS_SRC_ALPHA);

            Gl.glBegin(Gl.GL_QUADS);
            Gl.glColor3f(0.0f, 0.0f, 1.0f);
            Gl.glVertex2f(13.0f / 13.0f, 1.0f / 13.0f);
            Gl.glVertex2f(1.0f / 13.0f, 1.0f / 13.0f);
            Gl.glVertex2f(1.0f / 13.0f, 13.0f / 13.0f);
            Gl.glVertex2f(13.0f / 13.0f, 13.0f / 13.0f);

            Gl.glEnd();
            Gl.glFlush();
        }
        private void DrawTriangle()
        {
            Gl.glDisable(Gl.GL_LIGHT0);
            Gl.glDisable(Gl.GL_LIGHTING);
            // Очистка экрана и буфера глубин
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glLoadIdentity();

            GlutRotation();

            Gl.glEnable(Gl.GL_LINE_SMOOTH);
            Gl.glHint(Gl.GL_LINE_SMOOTH_HINT, Gl.GL_NICEST);
            Gl.glEnable(Gl.GL_POINT_SMOOTH);
            Gl.glHint(Gl.GL_POINT_SMOOTH_HINT, Gl.GL_NICEST);
            Gl.glEnable(Gl.GL_BLEND);
            Gl.glBlendFunc(Gl.GL_SRC_ALPHA, Gl.GL_ONE_MINUS_SRC_ALPHA);

            Gl.glBegin(Gl.GL_TRIANGLES);
            Gl.glColor3f(1.0f, 1.0f, 0.0f);
            Gl.glVertex2f(1.0f / 15.0f, 15.0f / 15.0f);
            Gl.glColor3f(0.0f, 1.0f, 0.5f);
            Gl.glVertex2f(13.0f / 15.0f, 1.0f / 15.0f);
            Gl.glColor3f(0.0f, 0.0f, 1.0f);
            Gl.glVertex2f(1.0f / 15.0f, 1.0f / 15.0f);

            Gl.glEnd();
            Gl.glFlush();
        }
        private void DrawPyramid(OpenGL pyramid)
        {
            pyramid.Disable(OpenGL.GL_LIGHT0);
            pyramid.Disable(OpenGL.GL_LIGHTING);
            // Очистка экрана и буфера глубин
            pyramid.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
            // Сбрасываем модельно-видовую матрицу 
            pyramid.LoadIdentity();

            Rotation(pyramid);

            // Рисуем треугольники - грани пирамиды
            pyramid.Begin(OpenGL.GL_TRIANGLES);
            // Front
            pyramid.Color(1.0f, 0.0f, 1.0f);
            pyramid.Vertex(0.0f, 1.0f, 0.0f); // вершина
            pyramid.Color(1.0f, 1.0f, 0.0f);
            pyramid.Vertex(-1.0f, -1.0f, 1.0f);
            pyramid.Color(0.0f, 0.0f, 1.0f);
            pyramid.Vertex(1.0f, -1.0f, 1.0f);
            // Right
            pyramid.Color(1.0f, 0.0f, 1.0f);
            pyramid.Vertex(0.0f, 1.0f, 0.0f);
            pyramid.Color(1.0f, 1.0f, 0.0f);
            pyramid.Vertex(1.0f, -1.0f, -1.0f);
            pyramid.Color(0.0f, 0.0f, 1.0f);
            pyramid.Vertex(1.0f, -1.0f, 1.0f);
            // Back
            pyramid.Color(1.0f, 0.0f, 1.0f);
            pyramid.Vertex(0.0f, 1.0f, 0.0f);
            pyramid.Color(1.0f, 1.0f, 0.0f);
            pyramid.Vertex(1.0f, -1.0f, -1.0f);
            pyramid.Color(0.0f, 0.0f, 1.0f);
            pyramid.Vertex(-1.0f, -1.0f, -1.0f);
            // Left
            pyramid.Color(1.0f, 0.0f, 1.0f);
            pyramid.Vertex(0.0f, 1.0f, 0.0f);
            pyramid.Color(1.0f, 1.0f, 0.0f);
            pyramid.Vertex(-1.0f, -1.0f, 1.0f);
            pyramid.Color(0.0f, 0.0f, 1.0f);
            pyramid.Vertex(-1.0f, -1.0f, -1.0f);
            pyramid.End();

            pyramid.Begin(OpenGL.GL_QUADS);

            pyramid.Color(1.0f, 1.0f, 0.0f);
            pyramid.Vertex(1.0f, -1.0f, -1.0f);
            pyramid.Color(0.0f, 0.0f, 1.0f);
            pyramid.Vertex(1.0f, -1.0f, 1.0f);
            pyramid.Color(1.0f, 1.0f, 0.0f);
            pyramid.Vertex(-1.0f, -1.0f, 1.0f);
            pyramid.Color(0.0f, 0.0f, 1.0f);
            pyramid.Vertex(-1.0f, -1.0f, -1.0f);

            pyramid.End();
            // Контроль полной отрисовки следующего изображения
            pyramid.Flush();
        }
        private void DrawTeapot()
        {
            Gl.glDisable(Gl.GL_BLEND);

            Gl.glColor3f(0, 1, 1);

            Gl.glPushMatrix(); 

            GlutRotation();

            // рисуем чайник с помощью библиотеки FreeGLUT 
            if (checkBoxType.Checked) Glut.glutWireTeapot(1);
            else Glut.glutSolidTeapot(1);

            Gl.glPopMatrix();
            Gl.glDisable(Gl.GL_LIGHTING); // Будем рассчитывать освещенность
            Gl.glFlush();
        }
        private void DrawTorus()
        {
            Gl.glDisable(Gl.GL_BLEND);

            Gl.glColor3f(0.3f, 0.16f, 0.2f);

            Gl.glPushMatrix();

            GlutRotation();

            if (checkBoxType.Checked) Glut.glutWireTorus(0.3, 0.65, 16, 16);
            else Glut.glutSolidTorus(0.3, 0.65, 16, 16);

            Gl.glPopMatrix();
            Gl.glDisable(Gl.GL_LIGHTING); // Будем рассчитывать освещенность
            Gl.glFlush();
        }
        private void DrawCone()
        {
            Gl.glDisable(Gl.GL_BLEND);

            Gl.glColor3f(1, 1, 0);

            Gl.glPushMatrix();

            GlutRotation();

            if (checkBoxType.Checked) Glut.glutWireCone(0.2, 0.75, 16, 8);
            else Glut.glutSolidCone(0.2, 0.75, 16, 8);

            Gl.glPopMatrix();
            Gl.glDisable(Gl.GL_LIGHTING); // Будем рассчитывать освещенность
            Gl.glFlush();
            
        }
        private void DrawCylinder()
        {
            Gl.glDisable(Gl.GL_BLEND);

            Gl.glColor3f(0.5f, 0.84f, 1f);

            Gl.glPushMatrix();

            GlutRotation();

            if (checkBoxType.Checked) Glut.glutWireCylinder(0.2, 0.75, 16, 16);
            else Glut.glutSolidCylinder(0.2, 0.75, 16, 16);

            Gl.glPopMatrix();
            Gl.glDisable(Gl.GL_LIGHTING); // Будем рассчитывать освещенность
            Gl.glFlush();
            
        }
        private void DrawDodecahedron()
        {
            Gl.glDisable(Gl.GL_BLEND);

            Gl.glColor3f(1, 0.4f, 0.75f);

            Gl.glPushMatrix();

            GlutRotation();

            Gl.glScaled(0.5, 0.5, 0.5);
            if (checkBoxType.Checked) Glut.glutWireDodecahedron();
            else Glut.glutSolidDodecahedron();

            Gl.glPopMatrix();
            Gl.glDisable(Gl.GL_LIGHTING); // Будем рассчитывать освещенность
            Gl.glFlush();
            
        }
        private void DrawIcosahedron()
        {
            Gl.glDisable(Gl.GL_BLEND);

            Gl.glColor3f(0.26f, 0.33f, 0.35f);

            Gl.glPushMatrix();

            GlutRotation();

            if (checkBoxType.Checked) Glut.glutWireIcosahedron();
            else Glut.glutSolidIcosahedron();

            Gl.glPopMatrix();
            Gl.glDisable(Gl.GL_LIGHTING); // Будем рассчитывать освещенность
            Gl.glFlush();
            
        }
        private void DrawOctahedron()
        {
            Gl.glDisable(Gl.GL_BLEND);

            Gl.glColor3f(0.31f, 0.76f, 0.47f);

            Gl.glPushMatrix();

            GlutRotation();

            if (checkBoxType.Checked) Glut.glutWireOctahedron();
            else Glut.glutSolidOctahedron();

            Gl.glPopMatrix();
            Gl.glDisable(Gl.GL_LIGHTING); // Будем рассчитывать освещенность
            Gl.glFlush();
            
        }
        private void DrawTetrahedron()
        {
            Gl.glDisable(Gl.GL_BLEND);

            Gl.glColor3f(1, 0.7f, 0.23f);

            Gl.glPushMatrix();

            GlutRotation();

            if (checkBoxType.Checked) Glut.glutWireTetrahedron();
            else Glut.glutSolidTetrahedron();

            Gl.glPopMatrix();
            Gl.glDisable(Gl.GL_LIGHTING); // Будем рассчитывать освещенность
            Gl.glFlush();
            
        }
        private void PrintText(double x, double y, double z, string text)
        {
            Gl.glRasterPos3d(x, y, z);
            Glut.glutBitmapString(Glut.GLUT_BITMAP_9_BY_15, text);
        }
        private void DrawAxis()
        {
            //выключение освещения
            Gl.glDisable(Gl.GL_LIGHT0);
            Gl.glDisable(Gl.GL_LIGHTING);

            // Очистка экрана и буфера глубин
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glLoadIdentity();
            Gl.glPushMatrix();

            //сглаживание линий
            Gl.glEnable(Gl.GL_LINE_SMOOTH);
            Gl.glHint(Gl.GL_LINE_SMOOTH_HINT, Gl.GL_NICEST);
            Gl.glEnable(Gl.GL_POINT_SMOOTH);
            Gl.glHint(Gl.GL_POINT_SMOOTH_HINT, Gl.GL_NICEST);
            Gl.glEnable(Gl.GL_BLEND);
            Gl.glBlendFunc(Gl.GL_SRC_ALPHA, Gl.GL_ONE_MINUS_SRC_ALPHA);

            GlutRotation();
            // подписи осей
            Gl.glColor3f(1f, 1f, 1f);
            PrintText(2, 0, 0, "X");
            PrintText(0, 2, 0, "Y");
            PrintText(0.1f, 0, -2, "Z");

            Gl.glLineWidth(2.0f);
            Gl.glBegin(Gl.GL_LINES);

            // ось X
            Gl.glColor3f(0, 0, 1);
            Gl.glVertex3f(0, 0, 0);
            Gl.glVertex3f(2, 0, 0);

            // стрелочка X
            Gl.glVertex3f(2, 0, 0);
            Gl.glVertex3f(1.8f, 0.1f, 0);

            Gl.glVertex3f(2, 0, 0);
            Gl.glVertex3f(1.8f, -0.1f, 0);

            // ось Y
            Gl.glColor3f(0, 1, 0);
            Gl.glVertex3f(0, 0, 0);
            Gl.glVertex3f(0, 2, 0);

            // стрелочка Y
            Gl.glVertex3f(0, 2, 0);
            Gl.glVertex3f(0.1f, 1.8f, 0);

            Gl.glVertex3f(0, 2, 0);
            Gl.glVertex3f(-0.1f, 1.8f, 0);

            // ось Z
            Gl.glColor3f(1, 0, 0);
            Gl.glVertex3f(0, 0, 0);
            Gl.glVertex3f(0, 0, -2);

            // стрелочка Z
            Gl.glVertex3f(0, 0, -2);
            Gl.glVertex3f(0.1f, 0.1f, -1.8f);

            Gl.glVertex3f(0, 0, -2);
            Gl.glVertex3f(-0.1f, -0.1f, -1.8f);
            Gl.glEnd();

            Gl.glPopMatrix();
            // прорисовка
            Gl.glFlush();

            //включение освещения
            Gl.glEnable(Gl.GL_LIGHTING);
            Gl.glEnable(Gl.GL_LIGHT0);

            if (!checkBoxLight.Checked)
            {
                Gl.glDisable(Gl.GL_LIGHT0);
                Gl.glDisable(Gl.GL_LIGHTING);
            }
        }
        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
            trackBarRotationX.Value = 0;
            trackBarRotationY.Value = 0;
            trackBarRotationZ.Value = 0;

            checkBoxRotationX.Checked = false;
            checkBoxRotationY.Checked = false;
            checkBoxRotationZ.Checked = false;

            openGLControl2.Invalidate();
        }
        private void openGLControl2_OpenGLDraw(object sender, SharpGL.RenderEventArgs args)
        {
            /*
             *0 Буква Z
             *1 Буква A
             *2 Треугольник
             *3 Квадрат
             *4 Пирамида
             *5 Куб
             *6 Сфера
             *7 Конус
             *8 Цилиндр
             *9 Чайник
             *10 Тор
             *11 Додeкаэдр
             *12 Икосаэдр
             *13 Октаэдр
             *14 Тетраэдр
            */
            // Создаем экземпляр
            OpenGL gl = openGLControl2.OpenGL;

            // Очистка экрана и буфера глубин
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
            Gl.glClearColor(0, 0, 0, 1);

            if (toolStripComboBox1.SelectedIndex > 1)
            {
                groupBox1.Visible = true;
                groupBox4.Visible = true;
                //DrawAxis();
                Gl.glClearColor(0, 0, 0, 1);
            }
            else
            {
                groupBox1.Visible = false;
                groupBox4.Visible = false;
                //Gl.glClearColor(255, 255, 255, 1);
            }
            //DrawAxis();
            if (toolStripComboBox1.SelectedIndex > 5) groupBox2.Visible = true;
            else groupBox2.Visible = false;

            //сбросить видовую матрицу
            Gl.glLoadIdentity();
            //сохранить текущие координаты
            Gl.glPushMatrix();

            if (checkBoxAxis.Checked) DrawAxis();

            float[] mtClr = new float[4];
            float[] lghtClr = new float[4];

            switch (toolStripComboBox1.SelectedIndex)
            {
                case 0:
                    //Gl.glClearColor(255, 255, 255, 1);
                    DrawLetterZ();
                    openGLControl2.Invalidate();
                    break;
                case 1:
                    DrawLetterA();
                    openGLControl2.Invalidate();
                    break;
                case 2:
                    DrawTriangle();
                    openGLControl2.Invalidate();
                    break;
                case 3:
                    DrawRectangle();
                    openGLControl2.Invalidate();
                    break;
                case 4:
                    DrawPyramid(gl);
                    openGLControl2.Invalidate();
                    break;
                case 5:
                    DrawCube(gl);
                    openGLControl2.Invalidate();
                    break;
                case 6:
                    DrawSphere();
                    mtClr[0] = 1; mtClr[1] = 0; mtClr[2] = 1; mtClr[3] = 0;
                    lghtClr[0] = 0.7f; lghtClr[1] = 0; lghtClr[2] = 1; lghtClr[3] = 0;
                    openGLControl2.Invalidate();
                    break;
                case 7:
                    DrawCone();
                    mtClr[0] = 1; mtClr[1] = 1; mtClr[2] = 0; mtClr[3] = 0;
                    lghtClr[0] = 1; lghtClr[1] = 0.7f; lghtClr[2] = 0; lghtClr[3] = 0;
                    openGLControl2.Invalidate();
                    break;
                case 8:
                    DrawCylinder();
                    mtClr[0] = 0.5f; mtClr[1] = 0.84f; mtClr[2] = 1; mtClr[3] = 0;
                    lghtClr[0] = 0.5f; lghtClr[1] = 0.5f; lghtClr[2] = 1; lghtClr[3] = 0;
                    openGLControl2.Invalidate();
                    break;
                case 9:
                    DrawTeapot();
                    mtClr[0] = 0; mtClr[1] = 1; mtClr[2] = 1; mtClr[3] = 0;
                    lghtClr[0] = 0; lghtClr[1] = 0.7f; lghtClr[2] = 1; lghtClr[3] = 0;
                    openGLControl2.Invalidate();
                    break;
                case 10:
                    DrawTorus();
                    mtClr[0] = 0.3f; mtClr[1] = 0.16f; mtClr[2] = 0.2f; mtClr[3] = 0;
                    lghtClr[0] = 0.23f; lghtClr[1] = 0.16f; lghtClr[2] = 0.2f; lghtClr[3] = 0;
                    openGLControl2.Invalidate();
                    break;
                case 11:
                    DrawDodecahedron();
                    mtClr[0] = 1; mtClr[1] = 0.4f; mtClr[2] = 0.75f; mtClr[3] = 0;
                    lghtClr[0] = 1; lghtClr[1] = 0.0f; lghtClr[2] = 0.75f; lghtClr[3] = 0;
                    openGLControl2.Invalidate();
                    break;
                case 12:
                    DrawIcosahedron();
                    mtClr[0] = 0.26f; mtClr[1] = 0.33f; mtClr[2] = 0.35f; mtClr[3] = 0;
                    lghtClr[0] = 0.26f; lghtClr[1] = 0.2f; lghtClr[2] = 0.35f; lghtClr[3] = 0;
                    openGLControl2.Invalidate();
                    break;
                case 13:
                    DrawOctahedron();
                    mtClr[0] = 0.31f; mtClr[1] = 0.76f; mtClr[2] = 0.47f; mtClr[3] = 0;
                    lghtClr[0] = 0.26f; lghtClr[1] = 0.76f; lghtClr[2] = 0.47f; lghtClr[3] = 0;
                    openGLControl2.Invalidate();
                    break;
                case 14:
                    DrawTetrahedron();
                    mtClr[0] = 1; mtClr[1] = 0.7f; mtClr[2] = 0.23f; mtClr[3] = 0;
                    lghtClr[0] = 1; lghtClr[1] = 0.4f; lghtClr[2] = 0; lghtClr[3] = 0;
                    openGLControl2.Invalidate();
                    break;
            }

            if (checkBoxLight.Checked) Lighting(mtClr, lghtClr);
            //вернуться к старым координатам
            Gl.glPopMatrix();
        }
    }
}