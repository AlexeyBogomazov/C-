#include "pch.h"
#include <iostream>
using namespace std;


int main() {
	bool a, b, c, d;
	cout << "Please, gather your documents" << endl;
	cout << "Please, check if you have a photo and input a number:" << endl;
	cout << "1 for Yes; 0 for No" << endl;
	cin >> a;
	
	if (a == 0) {
		cout << "Please, follow to the photobooth" << endl;
	}
	else {
		cout << "Was your photo taken less than 3 months ago?" << endl;
		cout << "1 for Yes; 0 for No" << endl;
		cin >> b;
		
		if (b == 0) {
			cout << "Please, follow to the photobooth" << endl;
		}
		else {
			cout << "Wasn't this photo used for a passport?" << endl;
			cout << "1 for Yes (was not); 0 for No (was)" << endl;
			cin >> c;
			
			if (c == 0)cout << "Please, follow to the photobooth" << endl;
			else cout << "Great! You don't need a new photo!" << endl;
		}
		}
		cout << "Please, check if your photo is pasted?" << endl;
		cout << "1 for Yes; 0 for No" << endl;
		cin >> d;
		
		if (d == 0) {
			cout << "Please, paste your photo!" << endl;
		}
		cout << "Please, proceed to pay and have a nice day!" << endl;

	}
	
// while (d != 0 || d != 1) cout << "Please, enter 1 (one) or 0 (zero)" << endl; cin >> d; Right now, unfortunately, I haven't figured out mechanism to protect if from entering different from 0 or 1 number, but I hope I'll figure it out //
