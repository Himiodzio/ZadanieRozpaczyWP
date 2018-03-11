#include<iostream>
#include<string>

using namespace std;


struct Samochod {
string model;
string producent;
int cena;
Samochod *nastepny;

Samochod() {
cout << "Podaj model: ";
cin >> model;
cout << "Podaj producent: ";
cin >> producent;
cout << "Podaj cene samochodu: ";
cin >> cena;
nastepny = NULL;
}

void wypisz(){
cout << "Model samochodu: " << model << endl;
cout <<" Producent: " << producent <<endl;
cout << "Cena (PLN):" << cena << endl;
}
};

void dodaj_samochod(Samochod **korzen){
Samochod *nowa = new Samochod;
Samochod *tmp = (*korzen), *tmp1 = NULL;

while (tmp != NULL && (tmp->producent).compare(nowa->producent) == -1){
tmp1 = tmp;
tmp = tmp->nastepny;
}

if (tmp != NULL && (tmp->producent).compare(nowa->producent) == 0) {
cout << "Samochod " << nowa->producent << " juz istanieje" << endl;
delete nowa;
}
else if ((*korzen) == NULL || (tmp == (*korzen) && (tmp->producent).compare(nowa->producent) == 1)){
nowa->nastepny = (*korzen);
(*korzen) = nowa;
}
else {
tmp1->nastepny = nowa;
nowa->nastepny = tmp;
}
}

void wypisz(Samochod *korzen){
cout << "Zawartosc: " << endl;

while(korzen != NULL){
korzen->wypisz();
korzen = korzen->nastepny;
}
}

bool usun_samochod(Samochod **korzen, string a){
if ((*korzen) == NULL){
return false;
}
Samochod *tmp = (*korzen), *tmp1 = NULL;

while(tmp != NULL && (tmp->producent).compare(a) != 0) {
tmp1 = tmp;
tmp = tmp->nastepny;
}
if (tmp == NULL){
return false;
}
else if (tmp == (*korzen)) {
(*korzen) = (*korzen)->nastepny;
delete tmp;
}
else {
tmp1->nastepny = tmp->nastepny;
delete tmp;
}
return true;
}
