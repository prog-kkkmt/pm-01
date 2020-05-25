#include <iostream>
using namespace std;

long double fact(int n){
	long f = 1;
	double result = 0.0;
	for(int i=1;i<=n;i++){
		f*=i;
		result+=1.0/f;
	}
	return result;
}


int main(){
	int n;
	cin>>n;
	cout << fact(n) << endl;
	return 0;
}
