/* Tema 9. polinoame reprezentate ca tablouri unidimensionale (prin gradul polinomului si vectorul coeficientilor(coeficientii pot fi de orice tip):

Clasa polinom, prietena a clasei pereche (implementata in LP2) sa fie clasa de baza pentru clasa Polinom_ireductibil. Clasa derivata trebuie sa contina constructor parametrizat prin care sa se evidentieze transmiterea parametrilor catre constructorul din clasa de baza, destructor si  o metoda care sa aplice criteriul lui Eisenstein de verificare a ireductibilitatii polinoamelor. Sa se evidentieze conceptul de functie virtuala (pura – daca este mai natural in implementare).
*/

#include <iostream>
#include<fstream>
#include<math.h>
#include<cmath>

using namespace std;

template<class T> class polinom;
template<class U> istream &operator>>(istream &c,polinom <U> &a);
template<class U> ostream &operator<<(ostream &c,polinom <U> &a);
template<class U> ifstream &operator>>(ifstream &c,polinom <U> &a);

template <class T>
class polinom
{

protected:
    int grad;
    T *coef;

public:

    template<class X> friend class pereche;
    polinom(int grad)    //CONSTRUCTOR
    { int i;
      this->grad = grad;
      this->coef = new T[grad+1];
      for (i=0;i<=grad;i++)
          this->coef[i] = 0;
    }

    polinom()    //CONSTRUCTOR
    { this->grad=-1; this->coef=NULL; }

    void reinit() { this->grad=-1;
                   delete[] this->coef;}

    int get_grad() {return this->grad;}

    friend istream &operator>> <>(istream &c,polinom <T> &a); //CITESTE
    friend ostream &operator<< <>(ostream &c,polinom <T> &a); //AFISEAZA
    friend ifstream &operator>> <>(ifstream &c,polinom <T> &a); //CITIRE FISIER
    T valoare(T); //VALOAREA UNUI POLINOM INTR-UN PUNCT
    polinom <T> operator+(polinom <T>); //ADUNARE
    polinom <T> operator-(polinom <T>); //SCADERE
    polinom <T> operator*(polinom <T>); //PRODUS
    virtual void Eisenstein()
    {
        cout<<"Eisenstein in clasa de baza!";
    }

};

template<class X> class polinom_ireductibil;
template<class U> istream &operator>>(istream &c,polinom_ireductibil<U> &a);

template<class X>
class polinom_ireductibil:public polinom<X>  //MOSTENIRE
{
  public:
     polinom_ireductibil() //CONSTRUCTOR
     {
         this->grad=-1;
         this->coef=NULL;
     }

     polinom_ireductibil(int grad):polinom<X>(grad) //CONSTRUCTOR PARAMETRIZAT
     {

     }

     ~polinom_ireductibil() //DESTRUCTOR
     {
        this->grad=-1;
        delete[] this->coef;

     }

     void Eisenstein();
     friend istream &operator>> <>(istream &c,polinom_ireductibil <X> &a);
};


template<class T>
void polinom_ireductibil<T>::Eisenstein()
{
    int i,j,ok,ok1;
    T r,d,a;
    bool gasit;

    d=this->coef[0];
    for(i=1;i<=this->grad;i++)
    {
       a=this->coef[i];
        while(a)
       {r=d%a;
        d=a;
        a=r;
       }
    }

    gasit=false;

    if(abs(d)==1) //sunt prime intre ele
    for(i=2;i<=100 && gasit==false ;i++)
     { ok=1;
       for(int d=2;d<=sqrt(i) && ok==1;d++)
          if(i%d==0)
                ok=0;

       if(ok==1) //am gasit un numar prim
       {   ok1=1;

           for(j=0;j<this->grad-1 && ok1==1;j++) //verificam daca divide toti coef
            if(this->coef[j]%i!=0)
                  ok1=0;

           if(ok1==1 && this->coef[this->grad-1]%(i*i)!=0) //daca i patrat nu divide ultimul coef
                 gasit=true;
       }
     }

     if(gasit==true)
        cout<<"POLINOM IREDUCTIBIL";
     else
        cout<<"Nu se poate aplica criteriul.";

}

template <class T>
istream& operator>>(istream& c,polinom_ireductibil<T>& a) //Supraincarcare >> prima clasa
{
     int i;

     cout<<"Introduceti gradul polinomului:"; cin>>a.grad;

     a.coef = new T[a.grad+1];

     cout<<"Dati coeficientii polinomului:"<<"\n";
      for (i=0;i<=a.grad;i++)
      {
          cout<<"Coeficientul lui X^"<<i<<"=";
          c>>a.coef[i];
      }

      return c;
}

template<class X> class pereche;
template<class U> istream &operator>>(istream &c,pereche <U> &m);
template<class U> ostream &operator<<(ostream &c,pereche <U> &m);

template <class X>
class pereche{

 X x;
 polinom <X> a;

 public:

    pereche() { }
    polinom<X> get_p() {return this->a;}
    void verif(); //VERIFICA RADACINA
    friend istream &operator>> <>(istream &c,pereche <X> &m);
    friend ostream &operator<< <>(ostream &c,pereche <X> &m);

};

template <class T>
istream& operator>>(istream& c,polinom<T>& a) //Supraincarcare >> prima clasa
{
     int i;

     cout<<"Introduceti gradul polinomului:"; cin>>a.grad;

     a.coef = new T[a.grad+1];

     cout<<"Dati coeficientii polinomului:"<<"\n";
      for (i=0;i<=a.grad;i++)
      {
          cout<<"Coeficientul lui X^"<<i<<"=";
          c>>a.coef[i];
      }

      return c;
}

template <class X>
istream &operator>>(istream &c,pereche <X> &m) //Supraincarcare >> a doua clasa
{


     cout<<"Introduceti x="; cin>>m.x;

     cin>>m.a;

     return c;
}

template <class T>
ostream &operator<<(ostream &c,polinom <T> &a) //Supraincarcare << prima clasa
{
    int i;
    for(i=0;i<a.grad;i++)
       c<<a.coef[i]<<"X^"<<i<<" + ";

    c<<a.coef[a.grad]<<"X^"<<a.grad<<"\n";

    return c;
}

template <class X>
ostream &operator<<(ostream &c,pereche <X> &m) //Supraincarcare << a doua clasa
{
    c<<"x="<<m.x<<"\n";
    c<<m.a;
    return c;

}

template <class T>
ifstream &operator>>(ifstream &c,polinom <T> &a)
{
     int i;

     c>>a.grad;

     a.coef = new T[a.grad+1];

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

template <class T>
T polinom<T>::valoare(T x)
{
    int i;
    T s=0;

    for(i=0;i<=grad;i++)
        s=s+coef[i]*putere(x,i);

    return s;
}

template <class T>
polinom<T> polinom<T>::operator+(polinom<T> b)
{
   int i,max1;

    if(this->grad>b.grad)
        max1=this->grad;
    else
        max1=b.grad;

    polinom<T> c(max1);

    for(i=0;i<=max1;i++)
        c.coef[i]=this->coef[i]+b.coef[i];

    return c;
}

template <class T>
polinom<T> polinom<T>::operator-(polinom<T> b)
{
    int i,maxim;

    if(this->grad>b.grad)
        maxim=this->grad;
    else
        maxim=b.grad;

    polinom<T> c(maxim);

    for(i=0;i<=maxim;i++)
        c.coef[i]=this->coef[i]-b.coef[i];

    return c;
}

template <class T>
polinom<T> polinom<T>::operator*(polinom<T> b)
{
    int i,j,g;

    g=this->grad+b.grad;

    polinom<T> c(g);

    for(i=0;i<=this->grad;i++)
        for(j=0;j<=b.grad;j++)
            c.coef[i+j]=c.coef[i+j]+this->coef[i]*b.coef[j];

    return c;
}

template <class X>
void pereche<X>::verif()
{
    if(this->a.valoare(this->x)==0)
        cout<<x<<" este radacina";
    else
        cout<<x<<" nu este radacina";
}

int main()
{
    int val,opt,sw;

    polinom<double> a,b,c,d,e;
    pereche<double> z;
    polinom_ireductibil<int> f;


    cout<<"Introduceti optiunea: \n 1. Introducere polinoame. \n 2. Valoarea unui polinom intr-un punct. \n 3. Suma polinoamelor. \n 4. Diferenta polinoamelor. \n 5. Produsul polinoamelor. \n 6. Citire pereche.\n 7. Verificare radacina.\n 8. Reinitializare. \n 9. Eisenstein. \n 0. EXIT\n";
    cin>>sw;


    while(sw!=0)
     { switch(sw){
	      case 1: {  cin>>a;
	                 a.Eisenstein();

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

         case 9: { cin>>f;

                   f.Eisenstein();
                   break; }

         case 0: break; }

       cout<<"\nIntroduceti o noua optiune:"; cin>>sw; }



    return 0;
}

