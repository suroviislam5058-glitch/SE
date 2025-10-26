
#include <iostream>


using namespace std;

class Stack {
private:
    int arr[100];
    int top;

public:

    Stack() {
        top = -1;
    }


    void push(int value) {
        if (top >= 100 - 1) {
            cout << "Stack Overflow! Cannot push " << value << ".\n";
        } else {
            arr[++top] = value;
            cout << value << " pushed into the stack.\n";
        }
    }

    // Method to pop the top element from the stack
    void pop() {
        if (top < 0) {
            cout << "Stack Underflow! No elements to pop.\n";
        } else {
            cout << "Popped element: " << arr[top--] << endl;
        }
    }

    // Method to check the top element of the stack
    int peek() {
        if (top < 0) {
            cout << "Stack is empty!\n";
            return -1;
        } else {
            return arr[top];
        }
    }

    // Method to check the size of the stack
    int size() {
        return top + 1;
    }

    // Method to check if the stack is empty
    bool isEmpty() {
        return (top < 0);
    }
};

int main() {
    Stack s;
    int choice, value;

    do {
        cout << "\nSelect an operation:\n";
        cout << "1. Push\n";
        cout << "2. Top\n";
        cout << "3. Size\n";
        cout << "4. Pop\n";
        cout << "5. Exit\n";
        cout << "Enter your choice: ";
        cin >> choice;

        switch (choice) {
            case 1: // Push operation
                cout << "Enter a value to push: ";
                cin >> value;
                s.push(value);
                break;

            case 2: // Top operation
                if (!s.isEmpty()) {
                    cout << "Top element: " << s.peek() << endl;
                }
                break;

            case 3: // Size operation
                cout << "Stack size: " << s.size() << endl;
                break;

            case 4: // Pop operation
                s.pop();
                break;

            case 5: // Exit
                cout << "Exiting the program.\n";
                break;

            default:
                cout << "Invalid choice! Please try again.\n";
                break;
        }
    } while (choice != 5);

    return 0;
}
