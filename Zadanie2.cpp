#include <iostream>
#include <string>
using namespace std;

class Gra {
protected:
string tytul;
double koszt;
string platforma;

public:
Gra(){
tytul = "Gra numer 1";
koszt=0;
platforma = "PC";
}

virtual string about(){
return tytul;
}

virtual double cena(){
return koszt;
}

virtual string platf(){
return tytul;
}

};

class Dekorator : public Gra {

public:
virtual string about(){
return "he";
}
virtual string platf(){
return "(PC)";
}
};

class Battlefield : public Gra {

public: Battlefield():Gra(){
tytul = "Battlefield";
koszt=75;
}

};

class CallOfDuty : public Gra {

public: CallOfDuty():Gra(){
tytul = "CallOfDuty";
koszt=95;
}

};

class DLC1 : public Dekorator {
Gra *car;

public: DLC1(Gra *tytul):Dekorator(){
car = tytul;
}

string about(){
return car->about() + platf() + " + DLC";
}

double cena(){
return car->cena()+45;
}
};

class LootBooksy : public Dekorator {
Gra *car;

public: LootBooksy(Gra *tytul):Dekorator(){
car = tytul;
}

string about()
{
return car->about() + " + Loot booksy";
}

double cena()
{
return car->cena() + 20;
}
};


int main(){

Gra *s1 = new Battlefield();
Gra *s2 = new CallOfDuty();

cout<<"Bez dodatkow"<<endl;
cout<<s1->about()<<" "<<s1->cena()<<endl;
cout<<s2->about()<<" "<<s2->cena()<<endl;

s1 = new DLC1(s1);
s2 = new DLC1(s2);
cout<<endl<<"Z DLC"<<endl;
cout<<s1->about()<<" "<<s1->cena()<<endl;
cout<<s2->about()<<" "<<s2->cena()<<endl;


s1 = new LootBooksy(s1);
s2 = new LootBooksy(s2);
cout<<endl<<"Z loot boksami (+ DLC)"<<endl;
cout<<s1->about()<<" "<<s1->cena()<<endl;
cout<<s2->about()<<" "<<s2->cena()<<endl;

cout<<endl<<"Premium Edition"<<endl;
Gra *s3 =  new LootBooksy( new DLC1( new Battlefield()));
cout<<s3->about()<<" "<<s3->cena()<<endl;

cout<<endl<<"Ultimate Edition"<<endl;
Gra *s4 =  new LootBooksy( new DLC1( new CallOfDuty()));
cout<<s4->about()<<" "<<s4->cena()<<endl;


return 0;
}
