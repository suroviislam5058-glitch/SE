#include <iostream>
#include <queue>

using namespace std;

int main() {
queue<int> q;
int input[4];

// Take input from users
cout << "Enter four elements: ";
for (int i = 0; i < 4; i++) {
cin >> input[i];
q.push(input[i]);
}

// a) Show the elements of the Queue
cout << "Elements of the Queue: ";
queue<int> q2 = q;
while (!q2.empty()) {
cout << q2.front() << " ";
q2.pop();
}
cout << endl;

// b) Add two elements to the Queue
int add1, add2;
cout << "Enter two elements to add: ";
cin >> add1 >> add2;
q.push(add1);
q.push(add2);

// c) Again, show the remaining elements of the Queue
cout << "Elements of the Queue after adding two elements: ";
q2 = q;
while (!q2.empty()) {
cout << q2.front() << " ";
q2.pop();
}
cout << endl;

// d) Check the Queue is full or empty
if (q.empty()) {
cout << "Queue is empty." << endl;
} else {
cout << "Queue is not empty." << endl;
}

return 0;
}



