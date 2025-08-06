#include <iostream>

void sum(int i, int a);

using namespace std;

int main(){
    sum(5,3);
    return 0;
}

void sum(int i, int a) {
    cout <<  i + a;
}
