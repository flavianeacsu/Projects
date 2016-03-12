#include <iostream>

using namespace std;
struct nod { int inf; int n; struct nod *leg[100];} ARB;
nod *coada[100];
int prim,ultim,maxim;


nod* Creare()
{

	int info,nr,i;
	nod *p;

	cout<<"Informatia nodului:"; cin>>info;

	p=new nod;
	p->inf=info;

	cout<<"Numarul descendentilor pentru "<<info<<": "; cin>>nr;
	p->n=nr;

	for(i=0;i<p->n;i++)
        p->leg[i]=Creare();

	return p;  //radacina arborelui
}

void Parcurgere_niveluri(nod *rad)
{
	nod *p;
	int i;
	prim=ultim=0;
	if(prim>ultim) cout<<"Coada este plina\n";
	  else
        coada[ultim++]=rad; //se introduce radacina in coada

	do{
		if(prim==ultim) p=0;
	       else p=coada[prim++];  //extrag un nod din coada
		if(p)
		{
			cout<<p->inf<<" ";  //afisez informatia nodului
			for(i=0;i<p->n;i++)
				if(prim>ultim) cout<<"Coada este plina\n";
	                else coada[ultim++]=p->leg[i];   //adaug in coada descendentii nodului
		}
	}while(p);
	cout<<"\n";
}

void Parcurgere_adancime(nod *p)
{

		int i;
  		if( p != NULL )
		{
	  		cout<<p->inf<<" ";
	  		for(i=0;i<p->n;i++)
		  	   Parcurgere_adancime(p->leg[i]);
	 	}
}

void Inaltime(nod *p,int niv)
{

		int i;
  		if( p != NULL )
		{
	  		if(niv>maxim) maxim=niv;
	  		for(i=0;i<p->n;i++)
		  	   Inaltime(p->leg[i],niv+1);
	 	}
}

void Frunze(nod *p)
{
    int i;
    if(p!=NULL)
    {
        if(p->n==0)
            cout<<p->inf<<" ";

        for(i=0;i<p->n;i++)
            Frunze(p->leg[i]);
    }
}


int main()
{
    nod *rad;
    int opt;

    cout<<"Introduceti optiunea: \n 1. Introducere arbore. \n 2. Afisarea parcurgerii pe niveluri. \n 3. Afisarea parcurgerii in adancime. \n 4. Afisarea inaltimii arborelui. \n 5. Afisarea frunzelor arborelui. \n 6. EXIT\n";
    cin>>opt;
    while(opt!=6)
     { switch(opt){
	      case 1: { cout<<"\nIntroduceti arborele:\n";
                    rad=Creare(); break; }

          case 2: { cout<<"\nParcurgerea pe niveluri:\n";
	                Parcurgere_niveluri(rad); break; }

	      case 3: { cout<<"\nParcurgerea in adancime:\n";
	                Parcurgere_adancime(rad); break; }

          case 4: { cout<<"\nInaltimea arborelui:\n";
	                maxim=0; Inaltime(rad,1);
	                cout<<maxim; break; }

          case 5: { cout<<"\nAfisarea frunzelor:\n";
	                Frunze(rad); break; }

          case 6: break; }

       cout<<"\nIntroduceti o noua optiune:"; cin>>opt; }

    return 0;
}
