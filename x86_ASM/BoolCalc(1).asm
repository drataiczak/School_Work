; Title: BoolCalc(1)
; Performs various operations

%include "Along32.asm"
%include "Functions.asm"

section .data
    msg0: dd "Please press a number to make a choice."
    msg1: dd "1. x AND y"
    msg2: dd "2. x OR y"
    msg3: dd "3. NOT x "
    msg4: dd "4. x XOR y"
    msg5: dd "5. Hex AND"
    msg6: dd "6. Hex OR"
    msg7: dd "7. Hex NOT"
    msg8: dd "8. Hex XOR"
    msg9: dd "9. Exit program"
    
section .text
global main
main:
    mov ebp, esp; for correct debugging
    mov edx, 100b    ; Set x
    mov ebx, 111b    ; set y
    
    mov eax, msg0
    call stringLineFeed
    
    mov eax, msg1
    call stringLineFeed
    
    mov eax, msg2
    call stringLineFeed
    
    mov eax, msg3
    call stringLineFeed
    
    mov eax, msg4
    call stringLineFeed
    
    mov eax, msg5
    call stringLineFeed
    
    mov eax, msg6
    call stringLineFeed
    
    mov eax, msg7
    call stringLineFeed
    
    mov eax, msg8
    call stringLineFeed
    
    mov eax, msg9
    call stringLineFeed
    
    call ReadInt    ; Read user's choice
    
    cmp eax, 1
        je .P1
    
    cmp eax, 2
        je .P2
    
    cmp eax, 3
        je .P3
    
    cmp eax, 4
        je .P4
    
    cmp eax, 5
        je .P5
        
    cmp eax, 6
        je .P6
        
    cmp eax, 7
        je .P7
        
    cmp eax, 8
        je .P8
        
    mov ebx, 1
    mov eax, 0
    int 80h
        
.P1:
    push eax
    push ecx
    
    AND edx, ebx 
    mov eax, edx ; Move result to eax for printing
    call WriteBin
    
    pop ecx
    pop eax
ret

.P2:
    push eax
    push ecx
    
    OR edx, ebx
    mov eax, edx ; Move result to eax for printing
    call WriteBin
    
    pop ecx
    pop eax
ret

.P3:
    push eax
    push ecx
    push ebx
    
    NOT edx
    mov eax, edx ; Move result to eax for printing
    call WriteBin
    
    pop ebx
    pop ecx
    pop eax
ret

.P4:
    push ecx
    push eax
    
    XOR edx, ebx
    mov edx, eax ; Move result to eax for printing
    call WriteBin
    
    pop eax
    pop ecx
ret

.P5:
    AND ebx, edx
    mov eax, ebx ; Move result to eax for printing
    call WriteHex
ret

.P6:
    OR ebx, edx
    mov eax, ebx ; Move result to eax for printing
    call WriteHex
ret

.P7:
    NOT ebx
    mov eax, ebx ; Move result to eax for printing
    call WriteHex
ret

.P8:
    XOR ebx, edx
    mov eax, ebx ; Move result to eax for printing
    call WriteHex
ret 