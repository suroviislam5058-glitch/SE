
#include <iostream>

using namespace std;

const int MAX_SIZE = 100; // Maximum size of the stack
int stack[MAX_SIZE]; // Stack array
int topIndex = -1; // Index of the top element

// Push an element onto the stack
void push(int value) {
    if (topIndex >= MAX_SIZE - 1) {
        cout << "Stack Overflow: Cannot push " << value << endl;
    } else {
        stack[++topIndex] = value;
        //cout << "Value pushed: " << value << endl;
    }
}

// Get the top element of the stack
int top() {
    if (topIndex < 0) {
        cout << "Stack is empty" << endl;
        return -1; // Return an invalid value
    }
    return stack[topIndex];
}

// Get the size of the stack
int size() {
    return topIndex + 1; // Size is topIndex + 1
}

// Pop the top element off the stack
void pop() {
    if (topIndex < 0) {
        cout << "Stack Underflow: Cannot pop from empty stack" << endl;
    } else {
        cout << "Top value popped: " << stack[topIndex--] << endl;
    }
}

int main() {
    int choice, value;

    do {
        cout << "\nStack Operations Menu:\n";
        cout << "1. Push\n";
        cout << "2. Top\n";
        cout << "3. Size\n";
        cout << "4. Pop\n";
        cout << "5. Exit\n";
        cout << "Enter your choice: ";
        cin >> choice;

        switch (choice) {
            case 1:
                cout << "Enter value to push: ";
                cin >> value;
                push(value);
                break;
            case 2:
                value = top();
                if (value != -1) {
                    cout << "Top value: " << value << endl;
                }
                break;
            case 3:
                cout << "Size of stack: " << size() << endl;
                break;
            case 4:
                pop();
                break;
            case 5:
                cout << "Exiting...\n";
                break;
            default:
                cout << "Invalid choice, please try again.\n";
        }
    } while (choice != 5);

    return 0;
}
