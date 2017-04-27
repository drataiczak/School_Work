;TITLE FibNums.asm 
;Test File

%include "Procedures.asm"
%include "Functions.asm"

section .text
global main
main:
    mov ebp, esp        ; for correct debugging
    call ReadInt        ; Read key to set counter
    mov ecx, eax        ; Set counter with desired number
    mov eax, 0          ; Put first number in eax
    mov ebx, 1          ; Put second number in ebx

L1:
    call FibNum         ; Call FibNum to find next number
    call intLineFeed    ; Print number from eax
    loop L1             ; Loop until ecx is 0

call exit               ; Exit the program
    