%include 'Functions.asm'

section .text
global main

main:
    mov eax, 1
    call intLineFeed
    call intLineFeed
    
    mov eax, 0
    mov ecx, 6
    mov edx, 1
    mov ebx, 1

L1:
    mov eax, edx
    add eax, ebx
    mov ebx, edx
    mov edx, eax
    call intLineFeed
    loop L1
    
    call exit