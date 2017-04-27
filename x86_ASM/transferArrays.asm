%include 'Functions.asm'
section .data
    wordArray dw 0, 1, 2, 3, 4, 5
    len equ $-wordArray
    doubleWordArray dd 0, 1, 2, 3, 4, 5; "%d", 6,0
    ddArray dd 0, 1, 2, 3, 4, 5
section .text
global main

main:
    mov ebp, esp; for correct debugging
    mov esi, wordArray
    mov edi, doubleWordArray
    mov ecx, 3

convert:
    mov ax, [esi + ecx * 2]
    movzx edi, ax
    inc ecx
    cmp ecx, len
    jne convert
    
    mov eax, doubleWordArray
    call intLineFeed
    call exit