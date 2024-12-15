﻿namespace day15;

public static class Input
{
    public const string ExampleInput = @"
########
#..O.O.#
##@.O..#
#...O..#
#.#.O..#
#...O..#
#......#
########

<^^>>>vv<v>>v<<
";

    public const string ExampleInput2 = @"
##########
#..O..O.O#
#......O.#
#.OO..O.O#
#..O@..O.#
#O#..O...#
#O..O..O.#
#.OO.O.OO#
#....O...#
##########

<vv>^<v^>v>^vv^v>v<>v^v<v<^vv<<<^><<><>>v<vvv<>^v^>^<<<><<v<<<v^vv^v>^
vvv<<^>^v^^><<>>><>^<<><^vv^^<>vvv<>><^^v>^>vv<>v<<<<v<^v>^<^^>>>^<v<v
><>vv>v^v^<>><>>>><^^>vv>v<^^^>>v^v^<^^>v^^>v^<^v>v<>>v^v^<v>v^^<^^vv<
<<v<^>>^^^^>>>v^<>vvv^><v<<<>^^^vv^<vvv>^>v<^^^^v<>^>vvvv><>>v^<<^^^^^
^><^><>>><>^^<<^^v>>><^<v>^<vv>>v>>>^v><>^v><<<<v>>v<v<v>vvv>^<><<>^><
^>><>^v<><^vvv<^^<><v<<<<<><^v<<<><<<^^<v<^^^><^>>^<v^><<<^>>^v<v^v<v^
>^>>^v>vv>^<<^v<>><<><<v<<v><>v<^vv<<<>^^v^>^^>>><<^v>>v^v><^^>>^<>vv^
<><^^>^^^<><vvvvv^v<v<<>^v<v>v<<^><<><<><<<^^<<<^<<>><<><^^^>^^<>^>v<>
^^>vv<^v^v<vv>^<><v<^v>^^^>>>^^vvv^>vvv<>>>^<^>>>>>^<<^v>^vvv<>^<><<v>
v^^>>><<^^<>>^v^<v^vv<>v^<<>^<^v^v><^<<<><<^<v><v<>vv>>v><v^<vv<>v^<<^
";

    public const string RawInput = @"
##################################################
#..O...OOO..O..O..O.O.OOOO.#OO...O.O.......OO....#
#O...OO#..#.#O...OOOO...O#O..O#.O..OO...O.O......#
#..OO......OO....#O...OO...O...#O........O......O#
##..#..OOO..O.....OO....##......OO..O.....O.O..O.#
#..O#.O.O..O..O.#OOOO...OO......#OO..OO..#.OOO...#
#O.....O.OOO....O....O#.....O.#....#........O.O..#
#...O....O.OO..O#..#O.#..O...........O#.....#O..O#
#....O....OO.O.##.......#....O.O.O.O.O..#O...O...#
#O......#..OO.....O...OO.OOO.#.O#.#..OO.....#.O.O#
#O....O.#O..O..O...O#.OO..O.........OOO..O...OOO.#
#OO..O....#OOO...#.O..#.....O#O#..#.......O..OO.##
#..O.O.......#O...#.#O..O#.O.O.OO...O......O.....#
#....O...O##.....O..OO#..#O..O.....O...O.#.#O....#
#...#.OO#.O.........O.....O..O.O#O#.....OO.O....##
#..#...OO.O#OOO..O.#..........O.......O..##O...O##
#.O..O.OO#.....OO.O.O....O.#.....O#OO..OOO.##....#
#O...OO#O......O...#.O....O...O.#......OO..O.O...#
#.#..O.......O..OO....OOOO...O#...O....#.O.O.....#
#...OO.OO..OO....OO...........#.O#...O#.O.O#.OO.##
#O....O..#O.....O#.......#.O....O.....O....O.O..O#
##..O..O.O..#..O#......O......O..O#...#.O..O...#O#
#OO..OO.O..OO....OO.O#.OO.O.O#OO.#.OOOO...#.OO#..#
#.#O.O..OO.O....O...O...O.......#O..#O#.........##
#O.#O..#.O....#.#O.O.O..@..O.......O#.O...#..O...#
#O...O..#.#..O.OO....O.....O.O#....O..O.O#.OO..O.#
#....O.....O#..O....#......O.O.#..OO#OOO.O#.....O#
#O.#.O..#O#.....OO.O..O......#O...O...OO.....O...#
##O.O.O....OO.OOOOO..O..#.....O#OO.......OO....#.#
#.OO..O#.OO.......OOO#.O..O.OO.O..OO...O...O..O#.#
#O.#O..#O..O...O...O..O..O..O.....OO..O..O.....OO#
#O......O...O.OO..O.#..O..OO..OO...OOO.O.......O.#
#.OO....#....OO........O..O...OOO...O.O...O#..O..#
#..O....#..OO.O.OO..O#OO...#..O...#....O.....O..O#
#O...O#O.O..OO.#O.OOO.#.O..O#.O.......OO.......O##
#..##...O..O...#O.OOO.OO.#....O..O.O.O...##O...O.#
###......#.OO#.....O.O......O#.O...OO......O..O#.#
#.O.......O#OO#.O.O..#.....OOO....#.....OOO.OO..O#
#.O.#....O....#...O.....O....#....O............O.#
#OO.O..OO..OO...O.O.....O.##O..............O....O#
#....O..OO.O..O.......OOO..O..#..#OOO.O.O....OO..#
#O..O#..O#.#...O......O..O..O.O.#....O....OO#..OO#
#...OO........#.........O........O..O.....O......#
#O..OOO..O...O.O.OO#O#..O##..#OOO.O.OO..O..O...O.#
#.....#..#.O.....O....O#OO....O..O......#........#
#.......O.O....O.OO.#..O#....#.O..O..OO..OO#O...##
#..OO..O..O..O..#OO.OOO.....#.O.O..O.OOO..#O.....#
#O.OOO.#..OO...O......O.#.O...#...O..O......OO...#
#..OOOO.O#..........#.OOO......#....OO..OO..O.O..#
##################################################

v<v^^><^<vv>^<v^>^<^><>^>>^vvvv>^<^><^vv^v><<>><v>^>v<<^>^^^^^>v<v<^v^v<v>>vv<^>v^^v><<<^<><^>^<^<^^^<^^^v><<>v<><<<v<v<<v>>>^v<<<>^<>^v<<^v<^>v<<>><<v^^^^^^v>>vv^>>^^>^v^v^<<>^v<v<^>><^<v^^^v^<^><>v^<^>vv>v><^<><>^^>>^^<>>^v>v<<^v^^>v^<<^v^^><^^>v>v<><>>vv<^^v>><v^vvv^v^^<>>v<^v^v<>v<vvv>^<v<^<v<>^^<<<<v<<<v^^><^<^^<vv^v^v>><^<>^^><<><>><><v<>^v^<^>v<<>><<<v>^>vv><<<<v^^>^vv>v<>>^><v^^^>vv<v^>v>>v^^^^>>^<v>v<<^><^<v>v^>>>^v>^<v>>^<vv<>>v>v>v^<v^v<^vv<^><<^>vv><^<>>^>>v^>^v<<><<v<>^<<^^>v^^<v<^^^^^^>^<^v>v><vv^^^>vv<^vv<>vv><^v>^v<>v^>^<>>>>><^>^<vv<<><<v^>>v><^<^<<<>><>vv^>>vv>^^<vv<><v>vvv^>^v><v^^>v><^>vv<v^v>v><v>>v<vv<v<^vv^vv>>^>>^v>^>^v<vv>^v^<><v<>v<<<<^v>>>v>>v<^v>^<^>^<^<vv<<^v^>^^>><v<<^<v>v<>^>v>^^vv<<v>^>^^<^>v^>>v>>><<vvvv^vv^><^^v^^v<<v>><^^>v>^v<v>v><>vv^><>><v><^v<v><vv>^<<>>><<>^^<^v<<^^>v^<^^><^v^^>>v>^^>>^<v><^>><<^^v<><<<v<>vv^^<vv><^>>>^<vv^><<<<<^<vv<><v^>>^>>>v>>>^^<<>^v>^^<^<<><vv^>v^>v<>>><<vv^<vvv<<<<^<^>^^^^vvv<^>v^<^>>v^<^^^<<vv>^<<^^v>^^<<^><vv><^v<>>v><^^
>>vv<vvv<^<>><<^vv<^><vv^>><>>^^<^>vvvv^^v>>^><^vv><v^^>^v<^v^>>v^^^<<<<<v^^<>><><>^>v>><^>v>v^<<<^>^<^<v><><v>^v^v<>vv<^<<>vv><^^<><<^^^^<vv>^^><^>v^<v^v^^v<<>><>v^<>v>>^^v^v^^vvvvv<>^>v^>>>>>v<<v<>>>^><^<<^^^v<>v<^<>>vv<>^<v<^>vv^^<<<<<>v<^v>><<^v^><<v<^>^v^<>><^<><<<v<^^><v<^^<>v^<>^><><v<^<v>>v<v^<<^<v<^v<>><<^><^<><<vv>^<^vv><<^><^>^^vvv<^v^^<>v><<v<v<v^>v^>^>^vv^v>v<<>><<<v^>>v<^>^^^<v><v<<<<v<>>v^<>>v<vv>v^v>^>^v>>^^vv<v^^>><<v><<><>vv>vv^<>v^v^^v><>>vvv^v<vv<>^>v<^<v><>^v>><<^^^<^^><v^^<vv^vv^<^><vv<^><^^>>><^>^>vvv><<<><vv>v<<^>><><<<v<<^v>><<<>^^v<<>>^>><^^v>>vv<^^^v<vv^^<^<<>^v>>^v<v><<^v^^v>><>vvv>>v^<v<<<<v^>^v^<^<^v^vv^<^v^^^>^v><v^v^v<>^<^<>^^^>^^<>v<<>^<><>>>>><><<>vvv>v>>v><>>>>v^^v^<^><><<>^v^^v><<^^v><<v<v>>>^vvv^>vvvvv<v^^>>>v^>><^>v<^>^^v^<<>v<<<>vvv^<v<v>^v^vv^^<>^<vv<>^><<><v<<<v^><<v^<<vv><v>><^<<^<vv^<<<^^^<^v^vv><<<<><>v^vv<<<^vv^>^<<<v<^^<^v<>><><^^^v>>^vv^<>vv^^<^vvv^<>>><<^<>v<^>^^<^>v<^<vv>>>^^<^<v<^^>>^^>>v>>v<v<>>v<<>>>>^v^vvv>><^>>^v><^^>^<>^>^^vv>^<<>>
<<v<v>v^v>v>^^<>v<><^>^v<^>v^><>^>^vvv>^<^v>vv^>vv^^^<>>>v^<>^^<v<^>v>^<>^<>^><vv><<<v<^^^v>vvvv^^v<v<><>v>vv<<v^^vv>^v^v<v><<^^^^<v<^v<vvv>v<vvv>v>v><<vvvv^<<>v><^>v>^^^><v>>^v^v>v^^>v>^^v>v<<^<v>><<v^>><<<>>vv><<^><<v>vv>>^<<>^^<^v><v<v<>v>^v>>^<>>vv<vv<<^<^v^<v<>>^v^^>^>v>><v^^v<><<>v>><><^vv^^^v>v>v<>v<v<<v<<<^<<<^>v^<<vvv<v<v><^><v>^>v><<^>>v>>vvvv<v>v>^^><^><^vv^<><vv<<<>v<v<^<^>v^<^>>vv><^>v<>v<v><>v<^^<^^<<vv<>v>^v>^^>^<<^vv^>v<>vvv<<<<>>>>v>>v<>>><vvv>v<vv<>v<<>vv>>^vv^^<v>>v>v^<^><^^><^<<>^>v<vvvv<^^v^vv><^<^>vv^<>vv<v^^v><<>v<^^v>vv>^<vv>>^<>>v<v^^<><>^<v<vv><>v<<v>v><>v^<>>v^v<>>>^>>>v>^<^v<^<^^vvvvv>^<v<<v>>>><<^v^^^<v^<^<<v<>v<<<^<^^v<<v>>vv<>>><><><<<>^<vv>>v><<><<>^^v><v>>vvv<^>v>^v<>>>^>>>^^^>v>><^^>v^vv^^v>>>^<>>vvv>v<v<vv^vv<^v^>>>^v>v>^vvv>^v>><<<v><^>^<^><vv<<>v>>>>^v<vvv>>^<>v>^^^><>>v^>>v>^^>v>^^>^^<v<>>><vvvvv<vvv^<<<v<<<>^^v<^><>^>v<^^>>v>>>>>^^<<^<><>^^>>>v><^>>^>^^^^><v^^><<<^<^vv>v<>^<<v^<^v^<<<<>><>>><^<><><v^v^<vv<>v<^>^>>>^<v><^v^^<<><>>v<<^v<<^v^^<<vvv^^
>^<<^>><>>^v>^<<^^vv<<>^^v^<v<^^<>><>^<<^^v^<v>><><v<v^<>v<^>^v>^v^v^><<>>^v>><>>^<<>vvv^<v>^v>v<vv<><<>^^^>>><<>^><vvvv^<<<v><<^v^^^>>vv^<^<v>v<<<><v>><>v^^^<^^^>^>>>v><v<v<<><><>vv^v^<^<<<^>vv^vv>vv<>>>^vvv<><>^><>^^vvvv<^v<<<v>><>^<<v<^<v<^><>^v^^>^^<<<>v<><vvvv>v>v<^vv>vv^^<^^>vv>>^<<<v^<<<<^>^><^>>^>>^^<vv^^v<^>><^^^v>^><^>^^<v^^^>>^^v>>>^<>>^v><vv^>v<>^<<^<^^v>><>>^^^>>v>><<^vvv<<^^v^>^vvvvv^v^vv><^^<v<vv>v>><^^v<>^v>>>^v<><v<<>^<v^>>vv>v^>><^<^<>v^<v^vv^^^^^>^><^>^<><^<v<><v>>>>v^>v<vv^<^vv^^v><><><vv^vvv^>v<v>^^<<^><<>vvv>^vvvv^<>^>><^>v<v<^v<v^^><>v^v^<v><<^<v><v^vvv>^vv>vvvv^^^vvv>>v>>^v>v^<<v^^<<<^>v<v>v>v<vv^><<v>^vv>>v<<^<>^>^v<<<^<>v<^<<^^>>><vv<^<^^v><vv>><vvv>v<^v>><^^v<v^<^<^v^v>^><vv>^^vvv<<v><<>v<v<vv>^<^><><<>v^^v^^^^^>vv^^v<^><^vv<<<v<>><^<^>vvv<<v<^^^^<^v^<><vv^>v<vv<>^^v^>^<v^^>v^>^^><>^><>^<v>^v><<<>^^<v^>^^<v^^>^><>^^<^<vv>vv<<<v>>^>v>vv^v><>vv^vv>^^^><<vv>^v>v^v^vv<<^^<^<^^^v^<v><<<v<<^v<vv<<>v^^<^<<v>v<^^<<vv^><<<v<v<vv<vv^^^>^v^>v^<<^^><^>v<<^<^^>><<>><<><><
>v<^^>>v<><vvv^<><><v>vv^<>^^^<v<>>><>><<<>v^^^<<^v>>><v>^>v^<>^vvvvv^>v^<<<<>^>v><^>^>>><v>><v>^^vv^<v^^^<<<>>>>^><>>>>vvv>^v<<<>v^<^v^<^<>^v><>^>v^^<><^v<^<<<>^v>><vv><><<>^<vv^>^>>v^vvv^<<<vv<vvv<<v>vvv<v^<>v>>^^<<vv>v<v<^^>^^>^>>>>vv<v>v^>>^<>v<>v^>v^>v<^<<^<<<^<>><v<^vv><<v><>vv<<<<v<>^^>v<^>v<>^><>^<vvv>><<><>>^vv<>>^<<<v^v^^v<<v<^<v<^^>v><<^<v^v^^v<^^><>>v<>><^^>>>v^^<>v><<v<>>v>>vv>^v>vv><>vv^^<<<v<vv>>><^<>^^<^>>>^<v<<v>><^^<<^<><v<v<v<><v>vv<<<^><<v^^>v<v><v^^vv^>v>^<^v>v>>><<^v><<>^v^^^>v>vv<v>^vv>vv<<v^<><<^>v>^v^<>v^^^<>^<<^<v^<>v<v<<v<v<<>^^vv>^>^>^v>>^>^>vv^vv<^v<<v>v^<><><^^v^>v^<^>^v^<v><<>v>><^<<^<^>^<<v<><<^^<v<v>v^<<v<<>^vv>>v^>><<^^v>^v^v<<^<^v>>^<^>v>^^v^v><^<^>^^v<<^v^<<^>v^>^<<v>><>v<>>>>><><><v^^v<v<<><^v<^<>>v<>v>^<v<^vv^>>><^v<v<>vv^v^<^<><<^>>^^<<<<>>v<v^^v>><^^^v>^v>v>><^<>>^v>>vv>^^>v><<v^<>^^<^^>^<v<<>><v^<>><v>v<^v<^v<<vv>><v<v<v^vv<<>^^>^<v>><v^^v^><><<^<^><^vv<<vvvv^>>^>vv^<^>><^<v>^><><^>v^>>^><^<^<v>^>^>>^v>v<>>vvv><v^<>^vv<<v<^^^^^^vv<<<^^v<^<^vv^v<
>><v<^<v^><>v^<>v^<<v^>>v<^v><v^<v<^><<>^>v<>>><><^^^vvv^^^^v>>^^v>><v<v<^<>vv^><><^^v^^vv>>^v<><<v^v>v^<^^<^^^><vv<v>^vv<v<^^<^vvv><<<^>><^^<^>^>>>^v<^^><>^>v><><v^<>v><v<v<<^<<vv>>^v<^v>^>>>v>>^>^<<><<^>>>^<>v^^v><^^<^^v<<><v>>^<>^><<<>>>^>><<vv>^<^<>><v>^<>v^>>>v<vv<^<^vv^vv>>>^^>>^v^v^>><><<<>vvvv<v>>><^<><><>^>v^^<v^<<>>>>v><v>vv^<>v>^^v^><^vv>><v>>>v^^vv><<^vv<^><><vv<><<v<v>^vvv^<>><^>><<<><<^>>v>><vv>v^v<^<>^<^v^>>^><><v>^vv>^<v<vvv^v^><>>>^v<<>><v<>v>^v>>v><<<^v<v><<>>v<^>^><v>v^^v^<>^><^<>^v^^^v^><<^vv<vv>^<v<v><<<vv><>>>v<<v^<>>>vv><v<><vvv>><<^>>>v^v^<^>^^vv>>v<v><^<>^^<<<^>v><>v>v<v^<>>^>v><>^>><<>^vv^v>^^v>v^^v>v><>^>^<>vv^<v^<>><^v<v><<^><^<<<v^^^<v^<>v<^>^v>^<^<>^>v>v>^>vv^^v<<><v>>><^<vv^<>v<<>>v<><v<vv<<^<v><>v^^^<v^v^<<^>^<<<<<<^>>>>>^^><<^>>^v>^><>v^>^v^v>>vvvv>vvv><v<<<^vv^>^^^><<<v<<>vv^>^<<v^<v>^v<<<^>v<<v<v<<^^^<<<^>><v<vv><vv>><<<<v^<^v<^^<<v<<<^<v>v^^^<<<<>vv>^v>^<v<^^v^>^v^><>>v^^>v^^^<^^<v>>^>>^<^><vv^v^<><><>^v>>>^<^v>>^vvv><><v<<^v<^><<v><vvv<>><<vv>><^>^v
>>^>^^^<v<>^v^^<<^^<v<<v>>^<vv<^<v^<^^v<^>^<vv>v<<v><v>vvv^>^v>>>>v<v^>v^<<>^<<>^v^^^><<vv>^^^<^v>^<>v<^><vv^>v><^^>>>^>v<<>^><>^^^>>vvv>^v^v>>>^<v>><^<<v^v>^v^>v>^v^<>^>>^>>>>>^<v^><<<>v<vv<<<^v>vv^^>^>>v><^<v<v<vvv<<<v>^<^><><vv><^^^^>v<v>>>v<<><^^>v^v<<v^^^v>><<>v^v<^^vv^>^v>^<^>^>v<<>v<v<^^<<<<^^>>v<>>v<><^^^v^<<><<^v^<v<<^>^>>^v^<^<>>^<<^>v<>>>^<vv^^vv<>><^^<v<v>^><vvv^^<>><>vvvv^>^v^><<<vv^^v^v<v<v<<^<>vv>^>>><>>vv^>^>>^^<v^<v^^<v<>^><<^>v<>^v><<v<v><^<^^<v>v>vv>^^^^vvv>^v>>^^^^<v^>>^^<^>vv^>^<^^^<^^<^>><>^<>^v<<v>vvv^v^<v^<<^v^<v>>v^><>><v<<^>^^^>vv^<<^<^<v^^<<<^<<><>^><>v^^><>^^^><<<vvvvv^^^<v<^^<>vv>>>^vv><v<>>^v>>><<>v><<<<<>><^vv><>>v<>^<v><<vvv<>><<><v^^<<<^<>^>^<^<<^^>^><>v<>vv<v<<><>^^v^>v<^^<v^^v><^^vv<>><>v>>v<>>v^^>v><><>v^v<^>><<>>^<^<v<>^><^<><>>><<<<><>^v<>^^<><<v>^>v<^<^<v>>^v^vvv<^vv^^>^^v<>>^^<^>^v>^><v<v<>v^<<<vvv^<>>vv^>>^<^v<<>v>v>^^<^<^<v>^<v><>vv>>^<^<^^^>>^^v^^^^<^vv<^^>^<><>v<>vv^>^v<><>>>><v^<v^><<^^^v>^>^>>^>>v>^vv>v^>vv^v<v^v<^<^>^vvvv^<><v>><<v>><^^v>>
^vv^<vv><^v<>^v><^v>><^<><^v^>v>^<^<>vv>>^<^^^v<<^^>v<vvvv^<<v>^<v^<v<v<^>>><v^>v><<vv^^<v>^<<<^>^v>v>>v>><>v^>v><>^>^>v<<<>^v><><><<>^>^v><>v<^<v<^v<>^<^v>v>^vv<v<>><<v<v>><vv>^<^<^^^<<>^<<<>v<<^^v>vv<^v^v>>^<v<^^vv^vv>>^^^v><>>^v<<^^>^>^>>^<<<v^^><<<^^v^vv<<>v^>>v>^vvvv<<><><>vvv^v><<^v^v^>^><vvv^<<^^<><^<<>^v^<v^v<<<>^^^^v^v<^^><<>^^>v><<^vv>>vv<v<v<<>v^^^<<v^^>^v>v>vvvv^v<v>v^^<>>^>^^>vv>^>>v>>><v^^>v<^<<><v<v^<^<v><><><^>>^^^>v<^v^><^v^>^><><>^v>^v^<><^>>vvv>v^v>><^^^vv<><>>>v>^<v<<^^v>>v<^vv<vv^^<v>v<^<^>v>v><v^><^><<^v>v<<<>^^>>>^vv<^v^<<><<^<^<v^^<v><>^>vvv<v<vv>^<^^^^><<>>v^>^<vv<v><<^^v<^>v^^^v^^<>v<<<v<><v<<>^v<>><<v^<^<^^^<<<<<>v>v^<^^<^><>^vv<>><^^v<^^^<^<<>v><<v^<<>v<<<^^><^<^vvv><vv^v>^><v^^v<v<v<<<vv>><^^>^><^>v<v<>vvv<<v>><v^v<vv<^vv<^v^>v<^^vv^^<>^v>^^><^^<vvv<^v><^v<<vv^>^v<v^<v^>v><^v^<>>vv^^>^<>v^v>v><<^<>>>v<><<<<>v<<<<<v<>^v>v^<^>><^^<v><vvvv^>^^>vv><><<^<^>^<>><^<v^^^<>>^<^^<vvvvvvv>^^<v<v<^>>v>vvvv>^<vv>^<<v^v>v^>>v^>^^v<v^>^>^^vvvv>v<>><^v>v<>vv><^v<^>>^^<vv^<
v<<v^v^>^<^<><>>^<v<^v^>^>^><v>v><^>^^>v><^<><<<<>^^v^^^v>^v^<^^vv^vvv>v^vv^>^<><vvv<<<vv<>^<v^v>^^^>><<><^>^>^^v>v^<>vv>v^>^v<<v<v^>>v^<>vv<<<<<^<>^vv>vvv><><>v^>^v<^vv><^vvv^^>>^^>v^^vvv^<^>>v<^>v<<v<vvv>>>>>v<><>v>>v^<^^>vv><<>^vv<^<>>>^>>^<<>><^>v<><>^>>>vv^<>><<>v>v^>>^vvv^v^<>><^^^v><<vv^^><v^v^><v<<^<<v<>^vv^<^><^v>v<><^vv>^^^<vv><vv^^><<v^vv>vv^<>^<v<v<vv>^<v^<<>vv<^v>^vv<>^vvv>>><<v<v>^v>>><<^>^<>^v>v<vv^^v<^^<>><^v^v<v<<^>>v<<<^v^>^>^><^vvv>>><^>>v^^^<<>><vv<><v<>>>v>^>vvv<<^>v^<^><<v<^v^>>>>v<^<vv>v<<^>^><><<vv>>>v^<>>v^^v<>v<v^v<v^<v<^^vv^>>v^>^<v<vv><v<<vv^>v^<<^^>v^v<^vv<v<vv>>^>vv^vv<>v^<<><<>vv<><^v<^v<^^>^<<^<>><v>v>v><<>^v^<<>><vvv>^v^v>^>>v^<^<vvvv^vv^v>v>>^><<<^^^vv>^<><^v>^v^v^<^>v<>^v^><v>><>><<<<<><>^^<>^<>^<v<v^<<<^v^>>>>>^^<v^^>><>^^^v>^<>^>^>>^<v<>^v<>^>v>^^>^^^^^vv<^<<^<<<^<^>>>^><^^v>^^^>>^>>v^v^v^^<vvv<>>>>v>vv>v>>v>^>^<>>^<><>>^>^vv>>>v^<>><<^^><v>v^>>><>v<v^<v<vv<^>^<><<^><v<v<vv^>>^><v^^><<<>><>>>v^>^<<<v<<v<vv>v>>>>>>^v^vvv^v^<vv>v>v>^v^v<>^^<v<v^vv>><<
v>^^^v<v<>>^^<>^>^^<<^^vvv><<>vv^^^<vv^^><>vvv<^v><<>>^v^^>^v<^^v<>>^>v><<^>^^<<<v<<>^<v>>>v<>v<^v^^vvv^<^><v<>v<v<<v<vv^<<<^<>v<>>^>v^<v>v>^<>>v^^<vv><v>^^^<v>^^v^^>^^><<v^><v>^^^v^^>v^v>^<><^>^<<>>v<^<^>^<><<^v><<^><^v<v>^<v<^^^^^^><v^v<>v<>><^^^^<^><v<<^>>v<^>v<<<^<>vv<>v<<v<v^v^v^<<><v<<<vvv>>^<^>^>v^vv<^v<v<><^<v<>v<<^>v^v>v^^<v>>^<v^^<vv<<>><^><>^>>v><^v^<>v<^v<^>^>v><vvv>>>><>^>>vv^><>><<^>>vv^>><>v>>>^^<^^>vvvv>^^<<><vv>>^>^^><>>>v^>v><vv>v^<vv<<><>><v<vv<v<v>^^<><v^>v^^^v<<<^<<v^^<v><^^<vv>^vv>><^^<><<v^<>><<><>^^^vvv^v<^^^^<v^>^>^^<v>v>v<v>v>>v<<^>>^^^v<vv^v<^v^<^v^>^<<><v<>>>v^><^><>>v>^>^^vv^^<^<^v<^>^<<>>>^^>v>>^^^^^>v<<^^^<<^^^v>v^^>v>>v<^<^<v>>>>>>^>^^^v^v^^<v<<<<><<^^<^v>><^v<>^>^^v>>v^^<>vvvv>v>^<^vv><v>v>><v<v^<^^^><<>^v^<v><>^v<vv><>^><>^^v<<v>v><>^<v<^v^v<<<><vv><<<>^<<v>><>><v^>>vvv^<vv>>v^<^^<v<><vv>>v^>>^>>>v>^>>>>^<v^<<vv>^v^^>><vv>>v>>>v>v<>^vv^v><<<>>vvv<><^^<^^^^>>v<vv^><v^v^^^vv><>v<^^^^vv<^^<v>^^^><^>^^><<^><<^><v<v>^vvv<><<v^<<^^<>>^v<v<v^<>>^<^v>vv^^<>^>v
<v<v<v^>^<>^v<><>v><<>v^<<><>^^<<v>><<^v<v^v<>>v<^<<v<^v<v^v>><><><<<v>^v^>^<v>^<<^v<vv^^^<>>v^^<vv>>^^^><<vvv>^^<<v>>><v^v>>>^v^<vv<^>^<^<<v<>v>v<<vv^>v<><>><<>v<><^^<^v^^^v><^^^<v>^>^v^^v>^<^><v^<>^>v<<v>><^vv><^<<<<vv^<^^^v>^v<^<<><^^<>^v>v<>>^^v>^>^^v<<^>vv<vv^<>vv^<<^<^>vvvvv^v<<v^^<^v<v>^<v^v>^>v^^>^>v^><v>^vv<vv^v^v>>v^><<<>^<<<^<<><>^v<v><vv^v^v^v^v<<v^>^<><^^><^><<>>><>vv>>>>^<<^>v<^v<<<v<>>^^>^>>vv<v<v<<v<v^^><>><>^>^<^<<v<v^vv<^<>vv^>^<>^vv^^^<<><v^>v<v^v^>>v<^>v<<<>^^>vv^<v^>^v<>^^>v^v<^><v^vv^>^v>vv^>^v^^>v^<^<^<v<<v^<<^^^v>><>>^^^^<^^>^>><v<<<><<^^<^<vv<^<><<v<<<><<v^^><<>vvv>^><<<vv>^>v>v>vvv^^v>>^v><>>v<><<>>>v^><^^<v<vv^<<<v^^>><^>v><<><<v<^v<<>^^><vv<^<vv>><>>><<><v^<^^<v<^vv>v>^>^>>^^<v<^v<vv>^<^>>^><>v>v<<<^><vv>^^<^^<>vvvv>>>>>^^<<<^>>vv^<vv<v^<<^>^^v^^>vv<<>vvv>v^>^v^<^^^>v>^<v<<^vv><v><v>><v>>>^v>^v^v>^<^>v><vv^^v<>>><<><>^>vv^vv<vvvv>vv<<vvvvvv>^>v><>v^vv<^v<v^^<v<v><^>>v^>>>vv^<v>v>v>>vv<v<><>>v^<v<<>>>>v^>^v>>>v^v<<<v>v><vv<>v<^>^<^>>v<v<>^v>v>^v<<<^^<<^^<<v^^
<>v>v^^>v<<>>>^v^v<>^>^>v^v><v>^>vv>vv<<v<v<^^v><>^^^<<^v<^^><>v>><v><^^vv><^v>>vv>vv^^<><vv^><>vv<v>>vv>vv<^^>v>v^v<>^^<<^<>>>v>^^<^>v>v^^v>vv<>^^v<<<>^<v<v^^<<<>^>^<>^>v<><v>>>>vv><v><<v<<><>><<<^>v^^^vv<v<<<<v>v>^<><>v>>^<<<>>^<vv^>v^v<v^>>>v>^>v>>^v<<><<vv<v^>v^^vv^>>v>v>v^v<v>v^>v>v><^<<vv><>>^<>^v<v>vvv>v>^v^>>^><vv^^^><>^<vv<^<>^v>><v>^v><><^vv<><^><<<v<^<v>v^<^v<>^vvv<><^v<v^><>v><>><<>^^v><^^<^>^^<>vv^^v<^^vv^<v<<^v<vv>><>v^<^v^<<v><v>><^v^^><^><v><>^^^<<^v<v>>>v<<v<<<vvv<>>^^>>^vv>><^^<<^^vvv^<v>>>vv^v><<>>^>^vv<>vv<>vv<>^^<><>>v<^<^^^>v<^^<>vv<^><v^><^<^^v^^>v<>>v>^v>>>vvvv>^v<<>v>^^<>vv><^v<^>^v<>v>^<^v>>^vv^v^>v>><v^><<>^^<>>^v^^^^>^^><v>^v>v^^vv>^v<><^v<<^v^^>>v>>vv<>^^>>>^^^^v>>^^^<v>^>v><vv><v<<v>^><^vv<>>vvv^^><^^<<v>^>^>v^^v<^>v><v^<>v>^vv<v>^v>v^^<>vv>><>v>v^>^^>v<>^>vv>>><^^v<vv>^^>vv><v^<<^<v^<^<v<vvvv^^^<^v><^<>>^^>^<v<v>^>>^^<<><^^v<v^v>vvv<vv>^v<v<<^<>>^vv>^>v^<<^<>><vv<>^^^><v<v><^>>><>^^><<^^^<vv<<<<v>>v>^><<><<<^vvv^^v<vv>^v>>^<<v>>^v^^>^><v>^<v<v^<>v<<<<>><^
^v<^vv>>>>vv>v>><^<<vv><<^<>>>^vv^v^v>vv^<<<v>>>v><v><>^><<<^>v^>v<v<v<<v>^>vv^>v^^>>^^><>>><<^<>^^<>><><><><><v<v^<v>v^^^vvv>>^vv>^>>>vvvvv><<^v<<>v^v<>^><>>>vv<^>vv^<^v<><v>^^>v<v<<>vv^^<>vvv^>>^>><v>v<^>>>>>>><<v>^<vv<>^<>v^>^><>v<vv><<>><<vv^>>^<^v<>>^v>^>>^vv>>v<^>^^<v^^vvv<<<vv><><v^><><>v>>v><<<<>^>><^<>v>^^<vv<^<v<<>v>>^^<<<<>>v>^>v>v<^<^>><vv>v>v><>^<>^^>>^<v<<^>^>^><>vv^vv>^^<>>^<v<^^<<<v><^^<^>vvv>v^^^>vvv><^>v<^<v^<>>>^v^^<<v^<<^v^><<><<vv>^><<v>>^v><v^v<^>v<v^^^<>v<v>^><<v<vv><>>v<<<<><<v><<vv<v>>^^>>^vvvv^<^<<v^<v<v><<^>v>v>^^><^v^^<>v^^>>^vv><^^v<<<<vv><v>^^><v^>>^>^v<<^><<>>^^<^v<v><vv^<<><<v>vvv>^<<vvvv^>v<><v^v^vv^v<v>v<>>^v^<v<<>^v^^><><<^^^^^^<vv^<<<vv<<v><vv<^^<^^vv<<<>><^^>v^v>^><><<^vvv>^^>>v<^<<<^>v<v<>v>vvvv^>>>v>^vv>^<<<v<<^>^<^><vv><<<^>>^^>>^vv>>>v>^vvvv^><v<^vv<^^<v<<><^vv>><>>^^^vv^^v^<>v<>><<<v^^>v>^<v>^v^<<<><>>>v^>^^^vv^v<<v^>^^><>v>v<^>><v<>v>^>v>vv^>^^^^^vv<v>>>^^^<^<<>>^^v<^^><vv^v><v<v^>>v>v<vv^^>><v^><vvvv^<vv<v<>>v><vvv>v<^^>^>^v><^>^v<v><<v<<>><^
>v^vv^v>^^<vv>^^v^<<v>^>><>^vv^>^<vv^><<<<^v^<<^><v<^vv^^v^<^vv><>vv<v>>vvvv^vv<^>vvvv^^^><>v><>^v><<<^<<^v>>vvv><^<<vv^<^^>v>><>v^^v>^><^>><>>>>><>v^<^v^>v^><v^>v<>vvv^<<v>>vvv>vv>v><<<>^^^<^>^^vv<>^<^v>^^v^v<><v<vv>>^<v>v^<^>^<><v<<<<>^vv>>v^>^v^<><v^<<^v^<>^v<^<v^^>v<<>><^^v>^>v>><v^<>>v><^v<^^vv^<^>>>^>v>>^>vv^><v<^v>^v<>><>^><<vv^<>vv>^<><^^v><><v>^>^<<v>>^^^>^v^v<^>>^vv^><<><<>>><^>>^>>>><^^^v^><<v^>^v>vv^<>><^^>v><<><v^<v^<v>>>v^>>>>><<vv>v<>v^^>v^v<^vv^^><vv^><v>^v^^><v<<>^>>><^^<^v^>v>><<^vv>vv>>^<vv<vv>^><<<vv<v<<^<^>^<vv^v^vv^vv<><^<<^^^v<^<v<>^^^v^^>v>^^>vvvv><^<^^^<v>vv<vv<^><^<>^v^<vv^<<v>>v>^<^^v^<^>v>><^^^<<>^<v>^><<>v><^^v><vv^>^^<vv>^<<v>v<^^>v<v^>>^^<^>v<<^v>^>^v>><v>^<>>>v^^v<v>>^vv>^><v>>^vv^>^>^>v^v><v>>v^v<^v^<^<v^><<<v<v^^v>>><><<^><<<^>>>vvv<<^<^>vv^^^^<<^v^><^>^v^>v^^>vv<<^<^^^v<v>^>>v^>^^><>>v><>>^<v<>^>>vvv<^<<<^vv>vv<v^<^v>><><<vvv^><<<^^<>^^<<^<^<^^^<>^<>^^v><^^vv<^<v<^^><<v^>>v^^v>^vv>^v<v<<><<^vvvvv>vv^v^>vv<^v<^<^<>^>^v^><v^<^<v<<^vv<>^>v^v>^v<^v^<>^<v>
>><vv<v>^<v<^v><^<>v>^><^v><vv>>^<v><v><^^<^>v>vv<<<v^^>^^^>>v<v><^^>v^>><v<<^vvvv<^>>vvv^>>>^^><>v<<<>^v>><^<v>vvv>vvv<vvvv>vvvv^vv^^>v<^>>>v<<vv<^>v^<<v^vv><<<^<<^^<>^><>><>^vv<^v<vv<<><v>^v><^<<v<<v^<>v<^v^>v^<>^vvv<<v>^v^>>v^^>v>^<v>>^><v>^v<vv><>v^>>>v^vvvvv<>v<><>v<^>>v<<v^<><v^>^<v^<^v^^v^^^>v<v<>vv^^<>^<^v^>>>^vv^v><^>^v<^<>v>v>^<v<>^^v^>^>><<vv^^^>><><>^^<>^<<>v>v<v<^<^vvv><<><><^>v>><><^^>>v<v<<v><>>>>v><<><<^<v<v^^>>^><^^>^<<>>>v<vv^^>v^v^>>>vv>^^^^<v^^>^<v>^><v^<vv^>>v^v>^vv<vvv>>>><^^v><^v^<>^<<>^>^^>vv^^v<>^^<^^^>><v<<v<v>^v^v><>^<^>>v<vv<v>v>>^^^^v^v<<<>v<^<><>>v>>>>>v>>>>^<^vvvv>>v<>>><v^^^>^^v<v^v^vv<><>^<v<^<<<<^^<<v^<>v>v<>^<^v^v<v^<^vvv><^>v<v<><<^<v^>vv^<<v^<^<<^<<<v><v<>^^v<>><v>^^^^v^>vv>v^^^^<^^<<v<<>><vv<>>><<^v<>>v<^><^<>v<vvv>v>^<>vvv^vv^v<<<><v<<<>v>v><><v<^v<>^^<>>>><>>^<<<^<^<v<>v>>>><v>>^>>>^<v>^v^<>>^<v^^^><^vv>>v><<^<v^v^v>v>^v^^v^>><v>^<>>^>v^^<^vv>v^v><v<<v>^<<>v^>vv><<^<v<><v>>^>>v<^<^^^^^<>>>>>vv<v>>^>^<>^<v>v><^v<v^^^^^<^><<<v^^><<><^<<v>>^^v<^<vv^
>><<^<<v<>^><^v>>>vv^<<><v>^<<<^>^><><v<^^^<^<>>>><vv<v^<v>^^vv>v^<<><vv^<^<vv>^>vv<^v^v>>v^<>v<<<<>>^<v>^<^<>^^<<>>>>^>><^>^<^^^>^^<vv>v^<><<^v^v^^^><^v>>>v>^^>^v>^>v>v<<<vv>><>v<^^v<>v>^<<<v^<>>>^^<<^^>>>^<^<^v^>><<v<<>^<^<v><<^<<v<<vvv<<>v<v<^<^>v^>vv^>vv<v^<<<v<^v^<v^v>v<v><v<^>>^^v><><^<v^>^^<<^^>^^^<>v>^>^<^<v>v>v<^^>vv<<><><>>>^^^>>^^^<><v><vv^<<>vv^v<v^>^v<^<vv^^>vvv><>^v^>^>>v<v^v<>>^^^<v^>^^<^<^v<<v^vv><>vv^<>>vvvvv<^^v^>^<vv^v>>><vvv>>>>v<^v>vv<v^v^<^><^<>v<>^v^^^^^<v>v^<>>>^v>^vv<<v<<v<v<vv<v>v^>v>^v>>v<>><>>v>v<<>>^v^vv<<vv^<<<>v^^>^<<v>^^^><v^^<^<vv<vvvv>v^^<<><<<>^<^>v>v^vv^><>>v>^>>>>>^^v><^<>v^<^v><^vv^<v<v<><<v><^<>vv<^^vv>>>>^vv<>v^v>^^<<<<v>v>>v><^>v^>>v^><^v^vv^vv<>^vv>v>>v>vv>^v<v^v^<^><<v^>vv^vv>>>v>v<v^<<>^vv<^^<^vv<>v^>^>>>vv><v^<v>>^v>>v<^v>>>>^<^v<<<>v^v^>^v<<vv^^^vvv>v<v><>^>^vvv^>^^>><^><><v><^^><<><<^<v>^vv>>^vv>>>>^^v<^<^^><<>vv^<^v<v<>^^<><^<<v^v^<<<>^vv^^^vv>>^^>^<<v>v>v^^v^v<>^v^^><><>v^^vv^v^v>>><<<^v>v^v><^^<>vvv>^v<^^v^^vv>^<^<v^^>^vvv^<>>^<>><<v><v
>^^vvv^><<^>^^v<<^v<^v^>vvv><vvv>><v<<<v^v^^<v>><<v><<v>^>vvv>>>v<<^>^<>^^<^<^^^v>^<>>^vvv^^<>vvv^^^<<>>>v<^v<<>^^^vv<<><<>v<>v>^<>>v^>^^v^>v<<^v<v<>^v^vvv>vvv<^<^><v>v>><<^<>>^v>^vv>vv^>^v^><>v^<^>vvv^v>>>^<>v<>^^^^<vv>>^>>>><><<>>v<<<vv^^>>v>^>vv^>^<<<>>^v^><^<vvvv^v^^<v^v^^<v^><>v>v<>v>>^^vvv>^v^<v<v^^<<^<vv^v<>v<v<<vvvv>^><v>>>>^>^^^<<<<<>^<><v<^<<^^vv^>v><v><^^>v^>^>^^^<<<><<><>^>><<^<<^v>^><>^^^^^<^^<^^^vvv^v^^<v<vv^<^<^v^v><<<>vv^v<><<v<v<^^>>^>>^<^v^v<>v^>^v<><<v^>v<<v<v^v>>^<<<^><>^^^<<><^<^^^>v<><v>v<>^>><vvv><v><^<^v^^<>^^^>>^^><vvv^<^<<><^^^v<v<>^^v^<v>><v^<<vv^>^>v^^<>^v<v>^vv<><^<^v<v<>>v<v><><^v^<vvv^>>v^vv<<v>>>^v>^<vv><v<>>^<v>>><vv>><v^^>>>>^^<>^v>>v<v^^^v^v<<^^>>^^^<>>>v>v><v><vv>><>>><>>v<>^^>>>^v<^^^^v^v><v><<^><>v^^<><<>v>>vvvvv^v>>>v^<v<<<^<<^^>v^^v^^^<vv<>^^<>>vv>^^v><v><v>v<<>^vv^<v>^v<v<v>>v^<<^vv^>>>vv>>^<<vv<<><^><^^vv^>^<<v^v^^<>>^>^v<<v^v>>v><<<<><v^>>>^<>>>^>^>>>^>><vv>>^<v>>v<<<<>^^<>^>v>v>^^v>v>v>>^^<<<<><v^^^>^v<v>><^vv^>><v<v<v>vv^<v><<vv<v><^^<><<^v<
v^<>v<<^><<<<>^v>^^<<><^>v<^>v<v>^v<<v>^^^vv<<<^v^^<^<v^v^v<><><<<^<v<^^<vv^^vvv<^v<>><>>^v>^v^^<>vvv^>^<>>v<^<<vv<^<v><v^>>^>v>vvvv<>>>vv><<^^>^<^^>v>><^^^^<v><>v<^^<<><<vv>v<vv<>vvv>^<<>>vv^>v>>vv^>>v<<^<<^^>><v^^<>>v<v<>v<<^<<^<vvv^^v><<>v^v<<v<<>vv^vvv>>^>^<<^><><<^<^v^>><vvv^<>vvv^^>^><^<<v^^>>^^<<>^^vv><>^vv><>v>>><v>>^<v<v<vv<^vv^^<v>v>>v<>>>>^>v><^^v<>>^>>v<^^^^>><^v^^v^v><<<^^>v<v>^>v^<><<vv<v<^^v>^>^><><>^v<^^^v>>^<^<v><^vvv>v^<^^^^^<v><><v^^<>><v^>^<v<^^>vvv<v<<<>>v<^>>>v<<>^vv>v^^vv<^<^v<>^v<<>v^v<^vv<>v>><<v>>^<>^<><v<<v^>v<v>><^>>v<>>^v<<^v<v<<^><^><<>>>>><v<^^><>><v>>v^^v<^<>^>>v><v<vv^vv><>v><v>>^v><>v<>^>v^<v^v<>>^>^vv><>^vvv^v^v>v^^v^<>^<>^^>v>>v^v^^><>^>^^<^>^>^v><v^<^>>vv>^<<<<^>^<^^>>>^>>^v<<>^<^<v^^vv^^^vv<<v>>v<vv<v<^<^v<<^<^^^<v<^v^<v><v^v>v<v<^>^^vv>^^<><<v>>^v<v<v><>>^^v<vv<>vvv<v^>v>vv<v><vvvv<vvvvv<v>v>^vv^>>v>^^^v>>><>^vv^^<v^v>>v<v^v<>v>^^v^^<>v^>>>><v><v^^<v^^>^^^>^>>^>^v^><vv>^v^^<^>>^vv^^v>v^><>vv<vv^>v><<<<^<<>>vvv^vvv<<<>><v>^<>>vv><>>>^v<>v<>^v>v<>>>
^>^v<><>v>>^^^v<<<^^<v^<v>v^<<<<v<>v^^^vvv>v>^<><><^<<^>>v>><<>>^^<<<>^<^<<>^<^vv>><^vv>>vv>v^><<><^^><>>>^^v<^<v><vv<<^^^^^>^v>>^>>>>^>v^>v^vv^>>>v^>v<>^><v^^^^>^<>^<vv<><>>v<<><^^<><vvv<<>^^<v>^<<^^^vvv><<^v<<<>^^^^v>v^<<<^<^<<v>^^><vv^><<>^^>><<>vvv^<><>>><v>v<v<<>>v>vv<><^<>>><<^<v>^^v^v<<><v<<>v^^<v>^^<^>v^v^^^^>^^>^>v^>^v><^vv>^><>>>^<^<v<>^^^vv^>^<<^>v>>v^^>^v^>^<vv^>^><vv<<>v^<vvvvv><^>>v<<>>>^>vv<>vv^<vv<v^<v^vv<^<^^vv<v>^^v<^<v>vvv^^^<^<v>^v<<>v><v<<<><>><><<<v^><>>v<vv^<>^<<>^><v^<<<>v>v<>v<<^<^<<^v<^>^>>>^>^^<v<v^<<^<^>vvv^<v<>^<><>v><<<<>v^^v^v^vv^v<^^^>^v>^^v>vv<>^<v<<><><^><<<v<>v^^<v>><^vv^^>vv<<<^^vvv<><>>>^v^><<v^vv><>^<v><<>>vv>^<v<>^<v^^^^v>^>>vv<vv>vv>>v><<^v<>><<><v<<<<^<^<^^>v<>>v^^<<<>v>^v><<>>>v<^<^>v>^v<<v>>^>^>vv<>>^<^vv^v^>^><^>^^<^<v^v><^v<<v^^<^^>>>^<<v<<vv^>v<v^>^vv^<vv><<<>vvvvv><<^>vvv<>>>v<<v<^>>^>^>v^vv^^^><v^<v^v<<vv<^<><><>v><v<<^vv<v<^<><<<><>>vv^>^v>v<><<>>v^^v^>^<v<<<v^v>vv<^<<vv^v^<v^^^^<vv^<v>^^<^>>^<<v>^>>v<<v^^<<v<vv<<v^><^^^^^<^v<^v<<v^^v>^v
>vv>vv>^^<v<vv^>><^>v<<>v<^^<^<^>v^<vv><>^><v^^^>><>^<^v>v^>vv>>^>><v^^^<^<^<^v<v><^^<>vv^<v<<<^<>v<v>v<<^v^^^>v><><^<^<<v<^v<vv>^vvvv<v<>^>>v<<^>>vv^vv>vv^<^<<<>^vv^<<>v^<^<^>>v>^<v>>>^><><^<v^>v^^>^>>v<<>^>><><<<<vvv^^vv<^<^>vv>><v<<>^vv<><<vv^<^<>^<<^v^v><<<>v>>^vv>>^><><>^^><^v<<>vv^>^v<^>^^^>><^v>v^v<>^^^^v><v<^^^^<v>>><^><<<v<vv^<vvvv^v>>v>v>^v^>v^^>^>>><>^<<^<^v^v<vv<<v>^>><^><<v<<<><^<<v<^<^<><<<v>v^>><vvv>v>v^<>v<vv<>v<<^vvv<^<<><>vvv<<^^v<>^<<^>><v^^v>>^>>v<>>^v^v>vvv^<<v<<<<>vv><><<v<>vv>^<v>^<vvvv^>^vv<><v<<>v^<><<^v<<vv^v>v^^^v^<<>v><>><<^>^^<v<<^vvv^^>^v<>>><<>><<>>>>>>>v>^v^>>^>>>>^vv<<v^^<v<<v^^>v<>^<^^>>v<<^v^v<<><v^^<v>v^>^<^vv>v><v<^<>v<<^v>v<>>^v>>v>^<vv>^^v>>^v>v>>>^<<vv<>>^<>^>^v^v<><^><>vv^<v^><>^^vvvv<<<><v^<<vvv^<>^<<^<^v>>><^>v^>><><<>^^^>vvvvv>v<<<vv<<>^vv^<<>^^<>>^>v^<v^^v^v<v^>><<v^^^v^v^^^v^vvvv<^^v^^<>vv>^><>>v<^^<v<^>>^^<<v>^>^^><v^<^^>^><^^>^vv>>>vv>vvv>>v<v>><^<<<vvv^><<>^>^><>^v<<vvv<^^v^<<<v>v>v><<^v><v>>^^<>>>vv>^^<v<^>v^^>>>vvv<>v<<<vv>>^v><^<<^<^v
";
}