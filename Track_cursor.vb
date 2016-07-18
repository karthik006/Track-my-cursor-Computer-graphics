#include<GL/glut.h>
#include<math.h>
void colorcircle(int x,int y,int r)
{
       double i;
       for(i=0;i<r;i++)
       {
               double j;
               glPointSize(5.0);
               glBegin(GL_POINTS);
               for(j=0;j<=360;j++)
               glVertex2f(x+sin(j)*i,y+cos(j)*i);
               glEnd();
       }
}

void rectangle(int xmin,int xmax,int ymin,int ymax)
{
       glBegin(GL_LINE_LOOP);
       glColor3f(0.0,0.0,0.0);
       glVertex2f(xmin,ymin);
       glVertex2f(xmax,ymin);
       glVertex2f(xmax,ymax);
   glVertex2f(xmin,ymax);
       glEnd();
}


void passive(int newx,int newy)
{

       int x,y;
       x=newx;
       y=500-newy;
       glColor3f(0.0,0.0,0.0);
       colorcircle(118+(x*0.13),268+(y*0.03),10);
glColor3f(0.0,0.0,0.0);
colorcircle(318+(x*0.128),268+(y*0.03),10);


glFlush();
glutPostRedisplay();
}


void display(void)
{
       glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT);
glColor3f(1.0,0.0,0.0);
colorcircle(250,250,200);
glLineWidth(3.0);
glColor3f(0.0,0.0,0.0);
glBegin(GL_LINES);
glVertex2f(200,300);
glVertex2f(400,300);
glEnd();
rectangle(100,200,250,300);
rectangle(300,400,250,300);
glBegin(GL_LINE_LOOP);
glVertex2f(250,250);
glVertex2f(225,225);
glVertex2f(275,275);
glEnd();
glBegin(GL_LINES);
glVertex2f(180,150);
glVertex2f(320,150);
glEnd();
glBegin(GL_POLYGON);
glVertex2f(350.0,530.0);
glVertex2f(150.0,530.0);
glVertex2f(100.0,400.0);
glVertex2f(400.0,400.0);
glEnd();
glBegin(GL_QUADS);
glVertex2f(40.0,430.0);
glVertex2f(40.0,380.0);
glVertex2f(460.0,380.0);
glVertex2f(460.0,430.0);
glEnd();

glFlush();
glutSwapBuffers();
}
void init()
{
       glClearColor(1.0,1.0,1.0,1.0);
       glMatrixMode(GL_PROJECTION);
       gluOrtho2D(0.0,1000.0,0.0,1000.0);
}

void main(int argc,char** argv)
{
       glutInit(&argc,argv);
       glutInitDisplayMode(GLUT_SINGLE|GLUT_RGB);
       glutInitWindowSize(500,500);
       glutInitWindowPosition(50,150);
       glutCreateWindow("CURSOR SEEK");
       glutDisplayFunc(display);
   glutPassiveMotionFunc(passive);
       init();
       glutMainLoop();
}