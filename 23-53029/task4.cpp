#include<iostream>
using namespace std;

int main() {
    int stack[100]; // Adjust the maximum size as needed
    int top = -1;

    // Get input from the user (minimum 5 elements)
    cout << "Enter at least 5 elements for the stack: ";
    for (int i = 0; i < 5; i++) {
        int element;
        cin >> element;
        if (top == 99) { // Check for overflow
            cout << "Stack overflow\n";
            break;
        }
        stack[++top] = element;
    }

    // Operations on the stack
    cout << "\nOperations on the stack:\n";

    // a) Show the elements of the stack
    cout << "Elements of the stack: ";
    for (int i = top; i >= 0; i--) {
        cout << stack[i] << " ";
    }
    cout << endl;

    // b) Add three elements to the stack
    cout << "Adding  four elements to the stack: ";
    for (int i = 0; i < 4; i++) {
        if (top == 99) { // Check for overflow
            cout << "Stack overflow\n";
            break;
        }
        int element;
        cin >> element;
        stack[++top] = element;
    }
    cout << "Done.\n";

    // c) Check if the stack is full or empty
    if (top == 99) {
        cout << "Stack is full.\n";
    } else if (top == -1) {
        cout << "Stack is empty.\n";
    } else {
        cout << "Stack is not full or empty.\n";
    }

    // e) Show the remaining elements of the stack
    cout << "Remaining elements of the stack: ";
    for (int i = top; i >= 0; i--) {
        cout << stack[i] << " ";
    }
    cout << endl;

    return 0;
}
