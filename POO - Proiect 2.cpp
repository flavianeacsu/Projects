#include <iostream>
#include<fstream>

using namespace std;

class polinom
{

    int grad;
    double *coef;

public:

    friend class pereche;
    polinom(int grad)    //CONSTRUCTOR
    { int i;
      this->grad = grad;
      this->coef = new double[grad+1];
      for (i=0;i<=grad;i++)
          this->coef[i] = 0;
    }

    polinom()    //CONSTRUCTOR
    { }

    void reinit() { this->grad=-1;
                   delete[] this->coef;}

    int get_grad() {return this->grad;}

    friend istream &operator>>(istream &c,polinom &a); //CITESTE
    friend ostream &operator<<(ostream &c,polinom &a); //AFISEAZA
    friend ifstream &operator>>(ifstream &c,polinom &a); //CITIRE FISIER
    double valoare(double); //VALOAREA UNUI POLINOM INTR-UN PUNCT
    polinom operator+(polinom); //ADUNARE
    polinom operator-(polinom); //SCADERE
    polinom operator*(polinom); //PRODUS

};

class pereche{

 double x;
 polinom a;

 public:

    pereche() { }
    polinom get_p() {return this->a;}
    void verif(); //VERIFICA RADACINA
    friend istream &operator>>(istream &c,pereche &m);
    friend ostream &operator<<(ostream &c,pereche &m);

};

istream &operator>>(istream &c,polinom &a) //Supraincarcare >> prima clasa
{
     int i;

     cout<<"Introduceti gradul polinomului:"; cin>>a.grad;

     a.coef = new double[a.grad+1];

     cout<<"Dati coeficientii polinomului:"<<"\n";
      for (i=0;i<=a.grad;i++)
      {
          cout<<"Coeficientul lui X^"<<i<<"=";
          c>>a.coef[i];
      }

      return c;
}

istream &operator>>(istream &c,pereche &m) //Supraincarcare >> a doua clasa
{


     cout<<"Introduceti x="; cin>>m.x;

     cin>>m.a;

     return c;
}


ostream &operator<<(ostream &c,polinom &a) //Supraincarcare << prima clasa
{
    int i;
    for(i=0;i<a.grad;i++)
       c<<a.coef[i]<<"X^"<<i<<" + ";

    c<<a.coef[a.grad]<<"X^"<<a.grad<<"\n";

    return c;
}

ostream &operator<<(ostream &c,pereche &m) //Supraincarcare << a doua clasa
{
    c<<"x="<<m.x<<"\n";
    c<<m.a;
    return c;

}

ifstream &operator>>(ifstream &c,polinom &a)
{
     int i;

     c>>a.grad;

     a.coef = new double[a.grad+1];

     for (i=0;i<=a.grad;i++)

            c>>a.coef[i];

      return c;
}

double putere(double x,int i)
{
  int j;
  double m=1;

  for(j=0;j<i;j++)
        m=m*x;

  return m;
}

double polinom::valoare(double x)
{
    int i;
    double s=0;

    for(i=0;i<=grad;i++)
        s=s+coef[i]*putere(x,i);

    return s;
}

polinom polinom::operator+(polinom b)
{
   int i,max1;

    if(this->grad>b.grad)
        max1=this->grad;
    else
        max1=b.grad;

    polinom c(max1);

    for(i=0;i<=max1;i++)
        c.coef[i]=this->coef[i]+b.coef[i];

    return c;
}

polinom polinom::operator-(polinom b)
{
    int i,maxim;

    if(this->grad>b.grad)
        maxim=this->grad;
    else
        maxim=b.grad;

    polinom c(maxim);

    for(i=0;i<=maxim;i++)
        c.coef[i]=this->coef[i]-b.coef[i];

    return c;
}

polinom polinom::operator*(polinom b)
{
    int i,j,g;

    g=this->grad+b.grad;

    polinom c(g);

    for(i=0;i<=this->grad;i++)
        for(j=0;j<=b.grad;j++)
            c.coef[i+j]=c.coef[i+j]+this->coef[i]*b.coef[j];

    return c;
}

void pereche::verif()
{
    if(this->a.valoare(this->x)==0)
        cout<<x<<" este radacina";
    else
        cout<<x<<" nu este radacina";
}

int main()
{
    int val,opt,sw;

    polinom a,b,c,d,e;
    pereche z;

    cout<<"Introduceti optiunea: \n 1. Introducere polinoame. \n 2. Valoarea unui polinom intr-un punct. \n 3. Suma polinoamelor. \n 4. Diferenta polinoamelor. \n 5. Produsul polinoamelor. \n 6. Citire pereche.\n 7. Verificare radacina.\n 8. Reinitializare. \n 9. EXIT\n";
    cin>>sw;


    while(sw!=9)
     { switch(sw){
	      case 1: {  cin>>a;

                     ifstream f1("date.in");
                     f1>>b;

                     f1.close();
                     break; }

         case 2: { cout<<"Ce polinom doriti sa calculati?\n"; cin>>opt;
                   cout<<"In ce punct doriti sa calculati polinomul "<<opt<<"?\n"; cin>>val;
                   if(opt==1)
                        cout<<"Valoarea polinomului "<<opt<<" in x="<<val<<"="<<a.valoare(val)<<'\n';
                   else
                        cout<<"Valoarea polinomului "<<opt<<" in x="<<val<<"="<<b.valoare(val)<<'\n';
                   break; }

         case 3: {
                    c=a+b;
                    cout<<"SUMA polinoamelor:"<<c<<'\n'; break; }

         case 4: {
                    d=a-b;
                    cout<<"DIFERENTA polinoamelor:"<<d<<'\n'; break; }

         case 5: {
                    e=a*b;
                    cout<<"PRODUSUL polinoamelor:"<<e<<'\n'; break; }

         case 6: {
                   cin>>z; break; }

         case 7: { z.verif(); break; }

         case 8: { a.reinit(); b.reinit(); c.reinit(); d.reinit(); e.reinit(); z.get_p().reinit(); break; }

         case 9: break; }

       cout<<"\nIntroduceti o noua optiune:"; cin>>sw; }

       polinom a[100];

    return 0;
}
