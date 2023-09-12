import Extensions

def Run():
    print("Завдання 6. Написати програму яка обраховує атаки шахматних фігур.")

    chess1_pos = 0, 0
    chess2_pos = 0, 0
    chess3_pos = 0, 0

    chess1_type = "Ферзь"
    chess2_type = "Король"
    chess3_type = "Ферзь"

    chess1_color = "Білий"
    chess2_color = "Чорний"
    chess3_color = "Чорний"

    chess1_pos = InputChessPosition(chess1_type, chess1_color)
    chess2_pos = InputChessPosition(chess2_type, chess2_color)
    chess3_pos = InputChessPosition(chess3_type, chess3_color)

    CalculateChessAttacks(chess1_pos, chess2_pos, chess3_pos,  # chess 1 attack
                          chess1_type, chess2_type, chess3_type,
                          chess1_color, chess2_color, chess3_color)
    CalculateChessAttacks(chess2_pos, chess1_pos, chess3_pos,  # chess 2 attack
                          chess2_type, chess1_type, chess3_type,
                          chess2_color, chess1_color, chess3_color)
    CalculateChessAttacks(chess3_pos, chess2_pos, chess1_pos,  # chess 3 attack
                          chess3_type, chess2_type, chess1_type,
                          chess3_color, chess2_color, chess1_color)


def IsQueenAttackingChess(queen_pos, attacked_chess_pos):
    return queen_pos[0] == attacked_chess_pos[0] or queen_pos[1] == attacked_chess_pos[1] or \
           abs(queen_pos[0] - attacked_chess_pos[0]) == abs(queen_pos[1] - attacked_chess_pos[1])

def IsKingAttackingChess(king_pos, attacked_chess_pos):
    delta_x = abs(king_pos[0] - attacked_chess_pos[0])
    delta_y = abs(king_pos[1] - attacked_chess_pos[1])
    return delta_x <= 1 and delta_y <= 1


def CalculateChessAttacks(attacking_chess_pos, chess2_pos, chess3_pos,
                          attacking_chess_type, chess2_type, chess3_type,
                          attacking_chess_color, chess2_color, chess3_color):

    if attacking_chess_type == "Ферзь":
        if attacking_chess_color != chess2_color and IsQueenAttackingChess(attacking_chess_pos, chess2_pos):
            print(f"{attacking_chess_color} ферзь атакує {chess2_color} {chess2_type}")

        if attacking_chess_color != chess3_color and IsQueenAttackingChess(attacking_chess_pos, chess3_pos):
            print(f"{attacking_chess_color} ферзь атакує {chess3_color} {chess3_type}")

    elif attacking_chess_type == "Король":
        if attacking_chess_color != chess2_color and IsKingAttackingChess(attacking_chess_pos, chess2_pos):
            print(f"{attacking_chess_color} король атакує {chess2_color} {chess2_type}")

        if attacking_chess_color != chess3_color and IsKingAttackingChess(attacking_chess_pos, chess3_pos):
            print(f"{attacking_chess_color} король атакує {chess3_color} {chess3_type}")

def InputChessPosition(type, color):
    print(f"Введіть позицію {color} {type}")

    x = Extensions.SafeIntInput("\tX")
    y = Extensions.SafeIntInput("\tY")

    return x, y