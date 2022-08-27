#include <thread>
#include <iostream>
#include <stdio.h>
#include <chrono>
#include <unistd.h>

// Function that wastes CPU cycles
void CPU_Waster() {
    printf("CPU Waster Process ID: %d\n", getpid());
    std::cout << "CPU Waster Thread ID: " << std::this_thread::get_id() << std::endl;
    while(true)
        continue;
}

int main() {
    printf("Main process ID: %d\n", getpid());
    std::cout << "Main Thread ID: " << std::this_thread::get_id() << std::endl;
    std::thread thread1(CPU_Waster);
    std::thread thread2(CPU_Waster);

    while(true) {
        std::this_thread::sleep_for(std::chrono::seconds(1));
    }
}