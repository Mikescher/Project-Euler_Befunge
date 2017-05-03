#!/usr/bin/env python3

# transpiled with BefunCompile v1.1.0 (c) 2015
import gzip, base64
_g = ("AR+LCAAAAAAABADtmk2PozgQhv+KQ3ouQUxjlwPpqIVW2sveZo9zGKUvK3H1Kafe/z4FzoexjTHd4Am0LUWNoZqXx1UUL1HO5CcOQsg2wEAZ0oqFk7uMUHJ/B5X7gWO9"
  + "iynpfkS5BcqFvu+iXJSLclEuykW5KBdK7rqPGEM9GuW85dwjyk0o56GpRXxJOXVfNyDKfVhuxFio3NhriHIWuU50J8pT13JiT7lu1Brk9H2jEhjlPnXSKBflliS37Y4o"
  + "tzq5ySSj3B+VM2P1SMuRKPfV5MxYQ8oaatnzteXmGFEuykW5LyCXh5VjYeVoWDkRVi4JK/dPWDnHdyhzyAVezN2q7ztY9X0XuGcGXsx198zAo0r+/zfZVTQ7JiT5dUz+"
  + "S87zi74fxTMq/UpfvpHXOYValieUqHj9neEH8MPx89cschVluahYXtMU8rZuKmgm/DLhzWR/mZDkZ0Iwdr9PdxiF+9tNno9LwHtWipwdU1rn7PU9O4gc2gng5EXkvJ1w"
  + "nOyzvcj37XQvKOBfCiKt/RPQXlcTfa3Sk/qv/ZMPjooAXmK22Z7eGG6kjCIaFaPW2La8dVrjymdjVvlDa9xdgjdN7+SQ81vW7hpXrhPKcRZFmYuC72pgTQ0UILe4KJjc"
  + "AlFQucV6z1LJ7J+6rcqSb88FfvWKc0VJ7aos6iNNy0K4T1iVZRtXOuOq8tBGHcyoE1Ym2eLu7bGZbgdLHWMx1BEnU3duT2eLOmf07SnHK6ZFzYo6paUA3CoFL2ooRedU"
  + "l9iDoCVGYOxBAG4dLFH0gPsx4qVz7Eyqo2/uiGesM0qlA0nHfOhA0jEnXfZIdFylAwcdokkyxEytdIhGH4kO0SQZYqYDdPRKB310Mnc7BvWzQvhHcyfpQNK5KpO1dODO"
  + "3WZ7fmsgASEPEnJeuko7crLRcd/cgewtBh15anPX0DFJR2ejOymt0kV3q0xJ1tTnQM/M7D2T2Juz/xWPjn1PN5tvzeP4hW42WU3Zs5y86rnjVzo2QAeSztIzifIaF4aO"
  + "9h4xK1PScRed2jMzC139+SseE+tBBwodH67MW8+00aWfv+Ixsf2louXu5lOclan2TBtd/2LOQid6j1grk8vnglfPtNE5vPYcdHnvEc1nZiN8pnxW633zMe876TOzET7z"
  + "SscMOv75Kx4T61eZXKXz9Zkto0YX+IngUZmqz8xG+EwbXeDK7L/NrT4zG+EzbXQBKlP0bHeH1Wf65Q7uvSU83Ynz5lsSTqDO+42fw2dmVjoEavzxtXU2bwCl2jrd3+N8"
  + "jE73x8o1uU/h8Jm+dFCqrfOR6VSfOUh3a53tW04pC/Qx6Uyf6ZO7Ox08NJ3pMwfpbq3z8XNn+kyTrnnrNnIH994yJZ3rrVuNcg7NZ0p3Zfeaw99qD48xuZtgaD7zSmfz"
  + "mgun4zodrIZO9ZnSf6yJTvWZV7pVVebNZ64vd6bPbBlXQmf6zPXRqT5zTXSmz1wTnekz10en+sy10CGTdMbSbjaeuDDt5rR0/c5YjinUJB0YdFCYdnOpdNyg44VpN5dK"
  + "R+9094d680ZaqJZlqXTdyrzTQaHazaXS8R46vorcWStTdsxLfS6Zjum54yodWzidtTJvdHzhdEplanZzlZUJKt2SK7P5jtL6RLjRwXR0yikq7Rf1+q8wJ6GrEpLYf2ks"
  + "Jjl/d/wGS+iz/X1bAAA=")
g = base64.b64decode(_g)[1:]
for i in range(base64.b64decode(_g)[0]):
    g = gzip.decompress(g)
g=list(g)
def gr(x,y):
    if(x>=0 and y>=0 and x<111 and y<211):
        return g[y*111 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<111 and y<211):
        g[y*111 + x]=v;
def td(a,b):
    return ((0)if(b==0)else(a//b))
def tm(a,b):
    return ((0)if(b==0)else(a%b))
s=[]
def sp():
    global s
    if (len(s) == 0):
        return 0
    return s.pop()
def sa(v):
    global s
    s.append(v)
def sr():
    global s
    if (len(s) == 0):
        return 0
    return s[-1]
def _0():
    gw(2,1,0)
    gw(2,3,2520)
    gw(3,1,0)
    gw(108,99,32)
    sa(9998)
    return 1
def _1():
    sa(sr());
    sa(32)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa((tm(sr(),100))+9)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),100))

    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr());

    return (205)if(sp()!=0)else(2)
def _2():
    gw(2,0,1)
    gw(3,0,gr(2,0)+1)
    gw(4,0,gr(3,0)+1)
    gw(5,0,gr(4,0)+1)
    gw((gr(2,0)*10)+gr(3,0),(gr(5,0)*10)+gr(4,0),88)
    gw(3,1,gr(3,1)+1)
    sp();
    return 3
def _3():
    global t0
    t0=gr(5,0)+1
    gw(5,0,gr(5,0)+1)
    t0=t0-5
    t0=t0-5

    return (204)if((t0)!=0)else(4)
def _4():
    global t0
    t0=gr(4,0)+1
    gw(4,0,gr(4,0)+1)
    t0=t0-9

    return (203)if((t0)!=0)else(5)
def _5():
    global t0
    t0=gr(3,0)+1
    gw(3,0,gr(3,0)+1)
    t0=t0-8

    return (202)if((t0)!=0)else(6)
def _6():
    global t0
    t0=gr(2,0)+1
    gw(2,0,gr(2,0)+1)
    t0=t0-7

    return (7)if((t0)!=0)else(8)
def _7():
    gw(3,0,gr(2,0)+1)
    gw(4,0,gr(3,0)+1)
    gw(5,0,gr(4,0)+1)
    gw((gr(2,0)*10)+gr(3,0),(gr(5,0)*10)+gr(4,0),88)
    gw(3,1,gr(3,1)+1)
    return 3
def _8():
    return (9)if(gr(3,1)-1==0)else(10)
def _9():
    print(gr(1,4),end="",flush=True)
    print(gr(2,4),end="",flush=True)
    print(gr(3,4),end="",flush=True)
    print(gr(4,4),end="",flush=True)
    return 206
def _10():
    gw(2,1,gr(2,1)+1)
    gw(3,1,0)
    gw(2,0,1)
    return 11
def _11():
    gw(3,0,gr(2,0)+1)
    return 12
def _12():
    gw(4,0,gr(3,0)+1)
    return 13
def _13():
    gw(5,0,gr(4,0)+1)
    return 14
def _14():
    return (15)if(gr((gr(2,0)*10)+gr(3,0),(gr(5,0)*10)+gr(4,0))!=88)else(19)
def _15():
    global t0
    t0=gr(5,0)+1
    gw(5,0,gr(5,0)+1)
    t0=t0-5
    t0=t0-5

    return (14)if((t0)!=0)else(16)
def _16():
    global t0
    t0=gr(4,0)+1
    gw(4,0,gr(4,0)+1)
    t0=t0-9

    return (13)if((t0)!=0)else(17)
def _17():
    global t0
    t0=gr(3,0)+1
    gw(3,0,gr(3,0)+1)
    t0=t0-8

    return (12)if((t0)!=0)else(18)
def _18():
    global t0
    t0=gr(2,0)+1
    gw(2,0,gr(2,0)+1)
    t0=t0-7

    return (11)if((t0)!=0)else(8)
def _19():
    gw(1,6,gr(2,0)*gr(2,3))
    gw(2,6,gr(3,0)*gr(2,3))
    gw(3,6,gr(4,0)*gr(2,3))
    gw(4,6,gr(5,0)*gr(2,3))
    gw(7,6,0)
    return 20
def _20():
    sa(gr(7,6))
    gw(7,6,gr(7,6)+1)
    sa(sr());

    return (21)if(sp()!=0)else(201)
def _21():
    sa(sp()-1);

    sa(sr());

    return (22)if(sp()!=0)else(200)
def _22():
    sa(sp()-1);

    sa(sr());

    return (23)if(sp()!=0)else(199)
def _23():
    sa(sp()-1);

    sa(sr());

    return (24)if(sp()!=0)else(198)
def _24():
    sa(sp()-1);

    sa(sr());

    return (25)if(sp()!=0)else(197)
def _25():
    sa(sp()-1);

    sa(sr());

    return (26)if(sp()!=0)else(196)
def _26():
    sa(sp()-1);

    sa(sr());

    return (27)if(sp()!=0)else(195)
def _27():
    sa(sp()-1);

    sa(sr());

    return (28)if(sp()!=0)else(194)
def _28():
    sa(sp()-1);

    sa(sr());

    return (29)if(sp()!=0)else(193)
def _29():
    sa(sp()-1);

    sa(sr());

    return (30)if(sp()!=0)else(192)
def _30():
    sa(sp()-1);

    sa(sr());

    return (31)if(sp()!=0)else(191)
def _31():
    sa(sp()-1);

    sa(sr());

    return (32)if(sp()!=0)else(190)
def _32():
    sa(sp()-1);

    sa(sr());

    return (33)if(sp()!=0)else(189)
def _33():
    sa(sp()-1);

    sa(sr());

    return (34)if(sp()!=0)else(188)
def _34():
    sa(sp()-1);

    sa(sr());

    return (35)if(sp()!=0)else(187)
def _35():
    sa(sp()-1);

    sa(sr());

    return (36)if(sp()!=0)else(186)
def _36():
    sa(sp()-1);

    sa(sr());

    return (37)if(sp()!=0)else(185)
def _37():
    sa(sp()-1);

    sa(sr());

    return (38)if(sp()!=0)else(184)
def _38():
    sa(sp()-1);

    sa(sr());

    return (39)if(sp()!=0)else(183)
def _39():
    sa(sp()-1);

    sa(sr());

    return (40)if(sp()!=0)else(182)
def _40():
    sa(sp()-1);

    sa(sr());

    return (41)if(sp()!=0)else(181)
def _41():
    sa(sp()-1);

    sa(sr());

    return (42)if(sp()!=0)else(180)
def _42():
    sa(sp()-1);

    sa(sr());

    return (43)if(sp()!=0)else(179)
def _43():
    sa(sp()-1);

    sa(sr());

    return (44)if(sp()!=0)else(178)
def _44():
    sa(sp()-1);

    sa(sr());

    return (45)if(sp()!=0)else(177)
def _45():
    sa(sp()-1);

    sa(sr());

    return (46)if(sp()!=0)else(176)
def _46():
    sa(sp()-1);

    sa(sr());

    return (47)if(sp()!=0)else(175)
def _47():
    sa(sp()-1);

    sa(sr());

    return (48)if(sp()!=0)else(174)
def _48():
    sa(sp()-1);

    sa(sr());

    return (49)if(sp()!=0)else(173)
def _49():
    sa(sp()-1);

    sa(sr());

    return (50)if(sp()!=0)else(172)
def _50():
    sa(sp()-1);

    sa(sr());

    return (51)if(sp()!=0)else(171)
def _51():
    sa(sp()-1);

    sa(sr());

    return (52)if(sp()!=0)else(170)
def _52():
    sa(sp()-1);

    sa(sr());

    return (53)if(sp()!=0)else(169)
def _53():
    sa(sp()-1);

    sa(sr());

    return (54)if(sp()!=0)else(168)
def _54():
    sa(sp()-1);

    sa(sr());

    return (55)if(sp()!=0)else(167)
def _55():
    sa(sp()-1);

    sa(sr());

    return (56)if(sp()!=0)else(166)
def _56():
    sa(sp()-1);

    sa(sr());

    return (57)if(sp()!=0)else(164)
def _57():
    sa(sp()-1);

    sa(sr());

    return (58)if(sp()!=0)else(162)
def _58():
    sa(sp()-1);

    sa(sr());

    return (59)if(sp()!=0)else(160)
def _59():
    sa(sp()-1);

    sa(sr());

    return (60)if(sp()!=0)else(158)
def _60():
    sa(sp()-1);

    sa(sr());

    return (61)if(sp()!=0)else(156)
def _61():
    sa(sp()-1);

    sa(sr());

    return (62)if(sp()!=0)else(154)
def _62():
    sa(sp()-1);

    sa(sr());

    return (63)if(sp()!=0)else(152)
def _63():
    sa(sp()-1);

    sa(sr());

    return (64)if(sp()!=0)else(150)
def _64():
    sa(sp()-1);

    sa(sr());

    return (65)if(sp()!=0)else(148)
def _65():
    sa(sp()-1);

    sa(sr());

    return (66)if(sp()!=0)else(146)
def _66():
    sa(sp()-1);

    sa(sr());

    return (67)if(sp()!=0)else(144)
def _67():
    sa(sp()-1);

    sa(sr());

    return (143)if(sp()!=0)else(68)
def _68():
    sp();

    return (20)if((gr(3,6))==0)else(69)
def _69():
    gw(7,7,0)
    gw(1,7,gr(1,6))
    gw(2,7,gr(2,6))
    gw(3,7,td(gr(4,6)*gr(2,3),gr(3,6)))
    return 70
def _70():
    sa(gr(7,7))
    gw(7,7,gr(7,7)+1)
    sa(sr());

    return (71)if(sp()!=0)else(142)
def _71():
    sa(sp()-1);

    sa(sr());

    return (72)if(sp()!=0)else(141)
def _72():
    sa(sp()-1);

    sa(sr());

    return (73)if(sp()!=0)else(140)
def _73():
    sa(sp()-1);

    sa(sr());

    return (74)if(sp()!=0)else(139)
def _74():
    sa(sp()-1);

    sa(sr());

    return (75)if(sp()!=0)else(138)
def _75():
    sa(sp()-1);

    sa(sr());

    return (76)if(sp()!=0)else(137)
def _76():
    sa(sp()-1);

    sa(sr());

    return (77)if(sp()!=0)else(136)
def _77():
    sa(sp()-1);

    sa(sr());

    return (78)if(sp()!=0)else(135)
def _78():
    sa(sp()-1);

    sa(sr());

    return (79)if(sp()!=0)else(134)
def _79():
    sa(sp()-1);

    sa(sr());

    return (80)if(sp()!=0)else(133)
def _80():
    sa(sp()-1);

    sa(sr());

    return (81)if(sp()!=0)else(132)
def _81():
    sa(sp()-1);

    sa(sr());

    return (82)if(sp()!=0)else(131)
def _82():
    sa(sp()-1);

    sa(sr());

    return (83)if(sp()!=0)else(130)
def _83():
    sa(sp()-1);

    sa(sr());

    return (84)if(sp()!=0)else(129)
def _84():
    sa(sp()-1);

    sa(sr());

    return (85)if(sp()!=0)else(128)
def _85():
    sa(sp()-1);

    sa(sr());

    return (86)if(sp()!=0)else(127)
def _86():
    sa(sp()-1);

    sa(sr());

    return (87)if(sp()!=0)else(126)
def _87():
    sa(sp()-1);

    sa(sr());

    return (88)if(sp()!=0)else(125)
def _88():
    sa(sp()-1);

    sa(sr());

    return (89)if(sp()!=0)else(123)
def _89():
    sa(sp()-1);

    sa(sr());

    return (90)if(sp()!=0)else(121)
def _90():
    sa(sp()-1);

    sa(sr());

    return (91)if(sp()!=0)else(119)
def _91():
    sa(sp()-1);

    sa(sr());

    return (92)if(sp()!=0)else(117)
def _92():
    sa(sp()-1);

    sa(sr());

    return (93)if(sp()!=0)else(115)
def _93():
    sa(sp()-1);

    sa(sr());

    return (114)if(sp()!=0)else(94)
def _94():
    sp();

    return (95)if((gr(2,7))==0)else(96)
def _95():
    sa(4)
    return 70
def _96():
    gw(7,8,0)
    gw(1,8,gr(1,7))
    gw(2,8,td(gr(3,7)*gr(2,3),gr(2,7)))
    return 97
def _97():
    sa(gr(7,8))
    gw(7,8,gr(7,8)+1)
    sa(sr());

    return (98)if(sp()!=0)else(113)
def _98():
    sa(sp()-1);

    sa(sr());

    return (99)if(sp()!=0)else(112)
def _99():
    sa(sp()-1);

    sa(sr());

    return (100)if(sp()!=0)else(111)
def _100():
    sa(sp()-1);

    sa(sr());

    return (101)if(sp()!=0)else(110)
def _101():
    sa(sp()-1);

    sa(sr());

    return (106)if(sp()!=0)else(102)
def _102():
    sp();

    return (97)if((gr(2,8))==0)else(103)
def _103():
    gw(1,9,td(gr(1,8)*gr(2,3),gr(2,8)))
    return 104
def _104():
    return (97)if((((1)if((td(gr(1,9),gr(2,3)))-gr(2,1)!=0)else(0))+((1)if(tm(gr(1,9),gr(2,3))!=0)else(0)))!=0)else(105)
def _105():
    gw(3,1,gr(3,1)+1)
    gw(1,4,gr(2,0))
    gw(2,4,gr(3,0))
    gw(3,4,gr(4,0))
    gw(4,4,gr(5,0))
    return 15
def _106():
    sa(sp()-1);

    sa(sr());

    return (109)if(sp()!=0)else(107)
def _107():
    sp();

    return (97)if((gr(1,8))==0)else(108)
def _108():
    gw(1,9,td(gr(2,8)*gr(2,3),gr(1,8)))
    return 104
def _109():
    sp();
    return 70
def _110():
    gw(1,9,td(gr(1,8)*gr(2,8),gr(2,3)))
    sp();
    return 104
def _111():
    gw(1,9,gr(2,8)-gr(1,8))
    sp();
    return 104
def _112():
    gw(1,9,gr(1,8)-gr(2,8))
    sp();
    return 104
def _113():
    gw(1,9,gr(1,8)+gr(2,8))
    sp();
    return 104
def _114():
    sp();
    return 20
def _115():
    sp();

    return (95)if((gr(2,7))==0)else(116)
def _116():
    gw(7,8,0)
    gw(1,8,gr(2,7))
    gw(2,8,td(gr(3,7)*gr(2,3),gr(1,7)))
    return 97
def _117():
    sp();

    return (95)if((gr(2,7))==0)else(118)
def _118():
    gw(7,8,0)
    gw(1,8,gr(1,7))
    gw(2,8,td(gr(2,7)*gr(2,3),gr(3,7)))
    return 97
def _119():
    sp();

    return (95)if((gr(2,7))==0)else(120)
def _120():
    gw(7,8,0)
    gw(1,8,gr(3,7))
    gw(2,8,td(gr(2,7)*gr(2,3),gr(1,7)))
    return 97
def _121():
    sp();

    return (95)if((gr(2,7))==0)else(122)
def _122():
    gw(7,8,0)
    gw(1,8,td(gr(1,7)*gr(2,3),gr(3,7)))
    gw(2,8,gr(2,7))
    return 97
def _123():
    sp();

    return (95)if((gr(2,7))==0)else(124)
def _124():
    gw(7,8,0)
    gw(1,8,td(gr(1,7)*gr(2,3),gr(2,7)))
    gw(2,8,gr(3,7))
    return 97
def _125():
    gw(7,8,0)
    gw(1,8,gr(1,7))
    gw(2,8,td(gr(3,7)*gr(2,7),gr(2,3)))
    sp();
    return 97
def _126():
    gw(7,8,0)
    gw(1,8,gr(2,7))
    gw(2,8,td(gr(3,7)*gr(1,7),gr(2,3)))
    sp();
    return 97
def _127():
    gw(7,8,0)
    gw(1,8,gr(1,7))
    gw(2,8,td(gr(2,7)*gr(3,7),gr(2,3)))
    sp();
    return 97
def _128():
    gw(7,8,0)
    gw(1,8,gr(3,7))
    gw(2,8,td(gr(2,7)*gr(1,7),gr(2,3)))
    sp();
    return 97
def _129():
    gw(7,8,0)
    gw(1,8,td(gr(1,7)*gr(3,7),gr(2,3)))
    gw(2,8,gr(2,7))
    sp();
    return 97
def _130():
    gw(7,8,0)
    gw(1,8,td(gr(1,7)*gr(2,7),gr(2,3)))
    gw(2,8,gr(3,7))
    sp();
    return 97
def _131():
    gw(7,8,0)
    gw(1,8,gr(1,7))
    gw(2,8,gr(3,7)-gr(2,7))
    sp();
    return 97
def _132():
    gw(7,8,0)
    gw(1,8,gr(2,7))
    gw(2,8,gr(3,7)-gr(1,7))
    sp();
    return 97
def _133():
    gw(7,8,0)
    gw(1,8,gr(1,7))
    gw(2,8,gr(2,7)-gr(3,7))
    sp();
    return 97
def _134():
    gw(7,8,0)
    gw(1,8,gr(3,7))
    gw(2,8,gr(2,7)-gr(1,7))
    sp();
    return 97
def _135():
    gw(7,8,0)
    gw(1,8,gr(1,7)-gr(3,7))
    gw(2,8,gr(2,7))
    sp();
    return 97
def _136():
    gw(7,8,0)
    gw(1,8,gr(1,7)-gr(2,7))
    gw(2,8,gr(3,7))
    sp();
    return 97
def _137():
    gw(7,8,0)
    gw(1,8,gr(1,7))
    gw(2,8,gr(3,7)+gr(2,7))
    sp();
    return 97
def _138():
    gw(7,8,0)
    gw(1,8,gr(2,7))
    gw(2,8,gr(3,7)+gr(1,7))
    sp();
    return 97
def _139():
    gw(7,8,0)
    gw(1,8,gr(1,7))
    gw(2,8,gr(2,7)+gr(3,7))
    sp();
    return 97
def _140():
    gw(7,8,0)
    gw(1,8,gr(3,7))
    gw(2,8,gr(2,7)+gr(1,7))
    sp();
    return 97
def _141():
    gw(7,8,0)
    gw(1,8,gr(1,7)+gr(3,7))
    gw(2,8,gr(2,7))
    sp();
    return 97
def _142():
    gw(7,8,0)
    gw(1,8,gr(1,7)+gr(2,7))
    gw(2,8,gr(3,7))
    sp();
    return 97
def _143():
    gw((gr(2,0)*10)+gr(3,0),(gr(5,0)*10)+gr(4,0),32)
    sp();
    return 15
def _144():
    sp();

    return (20)if((gr(2,6))==0)else(145)
def _145():
    gw(7,7,0)
    gw(1,7,gr(1,6))
    gw(2,7,gr(3,6))
    gw(3,7,td(gr(4,6)*gr(2,3),gr(2,6)))
    return 70
def _146():
    sp();

    return (20)if((gr(1,6))==0)else(147)
def _147():
    gw(7,7,0)
    gw(1,7,gr(3,6))
    gw(2,7,gr(2,6))
    gw(3,7,td(gr(4,6)*gr(2,3),gr(1,6)))
    return 70
def _148():
    sp();

    return (20)if((gr(4,6))==0)else(149)
def _149():
    gw(7,7,0)
    gw(1,7,gr(1,6))
    gw(2,7,gr(2,6))
    gw(3,7,td(gr(3,6)*gr(2,3),gr(4,6)))
    return 70
def _150():
    sp();

    return (20)if((gr(2,6))==0)else(151)
def _151():
    gw(7,7,0)
    gw(1,7,gr(1,6))
    gw(2,7,gr(4,6))
    gw(3,7,td(gr(3,6)*gr(2,3),gr(2,6)))
    return 70
def _152():
    sp();

    return (20)if((gr(1,6))==0)else(153)
def _153():
    gw(7,7,0)
    gw(1,7,gr(4,6))
    gw(2,7,gr(2,6))
    gw(3,7,td(gr(3,6)*gr(2,3),gr(1,6)))
    return 70
def _154():
    sp();

    return (20)if((gr(4,6))==0)else(155)
def _155():
    gw(7,7,0)
    gw(1,7,gr(1,6))
    gw(2,7,td(gr(2,6)*gr(2,3),gr(4,6)))
    gw(3,7,gr(3,6))
    return 70
def _156():
    sp();

    return (20)if((gr(3,6))==0)else(157)
def _157():
    gw(7,7,0)
    gw(1,7,gr(1,6))
    gw(2,7,td(gr(2,6)*gr(2,3),gr(3,6)))
    gw(3,7,gr(4,6))
    return 70
def _158():
    sp();

    return (20)if((gr(1,6))==0)else(159)
def _159():
    gw(7,7,0)
    gw(1,7,gr(4,6))
    gw(2,7,td(gr(2,6)*gr(2,3),gr(1,6)))
    gw(3,7,gr(3,6))
    return 70
def _160():
    sp();

    return (20)if((gr(4,6))==0)else(161)
def _161():
    gw(7,7,0)
    gw(1,7,td(gr(1,6)*gr(2,3),gr(4,6)))
    gw(2,7,gr(2,6))
    gw(3,7,gr(3,6))
    return 70
def _162():
    sp();

    return (20)if((gr(3,6))==0)else(163)
def _163():
    gw(7,7,0)
    gw(1,7,td(gr(1,6)*gr(2,3),gr(3,6)))
    gw(2,7,gr(2,6))
    gw(3,7,gr(4,6))
    return 70
def _164():
    sp();

    return (20)if((gr(2,6))==0)else(165)
def _165():
    gw(7,7,0)
    gw(1,7,td(gr(1,6)*gr(2,3),gr(2,6)))
    gw(2,7,gr(3,6))
    gw(3,7,gr(4,6))
    return 70
def _166():
    gw(7,7,0)
    gw(1,7,gr(1,6))
    gw(2,7,gr(2,6))
    gw(3,7,td(gr(4,6)*gr(3,6),gr(2,3)))
    sp();
    return 70
def _167():
    gw(7,7,0)
    gw(1,7,gr(1,6))
    gw(2,7,gr(3,6))
    gw(3,7,td(gr(4,6)*gr(2,6),gr(2,3)))
    sp();
    return 70
def _168():
    gw(7,7,0)
    gw(1,7,gr(3,6))
    gw(2,7,gr(2,6))
    gw(3,7,td(gr(4,6)*gr(1,6),gr(2,3)))
    sp();
    return 70
def _169():
    gw(7,7,0)
    gw(1,7,gr(1,6))
    gw(2,7,gr(2,6))
    gw(3,7,td(gr(3,6)*gr(4,6),gr(2,3)))
    sp();
    return 70
def _170():
    gw(7,7,0)
    gw(1,7,gr(1,6))
    gw(2,7,gr(4,6))
    gw(3,7,td(gr(3,6)*gr(2,6),gr(2,3)))
    sp();
    return 70
def _171():
    gw(7,7,0)
    gw(1,7,gr(4,6))
    gw(2,7,gr(2,6))
    gw(3,7,td(gr(3,6)*gr(1,6),gr(2,3)))
    sp();
    return 70
def _172():
    gw(7,7,0)
    gw(1,7,gr(1,6))
    gw(2,7,td(gr(2,6)*gr(4,6),gr(2,3)))
    gw(3,7,gr(3,6))
    sp();
    return 70
def _173():
    gw(7,7,0)
    gw(1,7,gr(1,6))
    gw(2,7,td(gr(2,6)*gr(3,6),gr(2,3)))
    gw(3,7,gr(4,6))
    sp();
    return 70
def _174():
    gw(7,7,0)
    gw(1,7,gr(4,6))
    gw(2,7,td(gr(2,6)*gr(1,6),gr(2,3)))
    gw(3,7,gr(3,6))
    sp();
    return 70
def _175():
    gw(7,7,0)
    gw(1,7,td(gr(1,6)*gr(4,6),gr(2,3)))
    gw(2,7,gr(2,6))
    gw(3,7,gr(3,6))
    sp();
    return 70
def _176():
    gw(7,7,0)
    gw(1,7,td(gr(1,6)*gr(3,6),gr(2,3)))
    gw(2,7,gr(2,6))
    gw(3,7,gr(4,6))
    sp();
    return 70
def _177():
    gw(7,7,0)
    gw(1,7,td(gr(1,6)*gr(2,6),gr(2,3)))
    gw(2,7,gr(3,6))
    gw(3,7,gr(4,6))
    sp();
    return 70
def _178():
    gw(7,7,0)
    gw(1,7,gr(1,6))
    gw(2,7,gr(2,6))
    gw(3,7,gr(4,6)-gr(3,6))
    sp();
    return 70
def _179():
    gw(7,7,0)
    gw(1,7,gr(1,6))
    gw(2,7,gr(3,6))
    gw(3,7,gr(4,6)-gr(2,6))
    sp();
    return 70
def _180():
    gw(7,7,0)
    gw(1,7,gr(3,6))
    gw(2,7,gr(2,6))
    gw(3,7,gr(4,6)-gr(1,6))
    sp();
    return 70
def _181():
    gw(7,7,0)
    gw(1,7,gr(1,6))
    gw(2,7,gr(2,6))
    gw(3,7,gr(3,6)-gr(4,6))
    sp();
    return 70
def _182():
    gw(7,7,0)
    gw(1,7,gr(1,6))
    gw(2,7,gr(4,6))
    gw(3,7,gr(3,6)-gr(2,6))
    sp();
    return 70
def _183():
    gw(7,7,0)
    gw(1,7,gr(4,6))
    gw(2,7,gr(2,6))
    gw(3,7,gr(3,6)-gr(1,6))
    sp();
    return 70
def _184():
    gw(7,7,0)
    gw(1,7,gr(1,6))
    gw(2,7,gr(2,6)-gr(4,6))
    gw(3,7,gr(3,6))
    sp();
    return 70
def _185():
    gw(7,7,0)
    gw(1,7,gr(1,6))
    gw(2,7,gr(2,6)-gr(3,6))
    gw(3,7,gr(4,6))
    sp();
    return 70
def _186():
    gw(7,7,0)
    gw(1,7,gr(4,6))
    gw(2,7,gr(2,6)-gr(1,6))
    gw(3,7,gr(3,6))
    sp();
    return 70
def _187():
    gw(7,7,0)
    gw(1,7,gr(1,6)-gr(4,6))
    gw(2,7,gr(2,6))
    gw(3,7,gr(3,6))
    sp();
    return 70
def _188():
    gw(7,7,0)
    gw(1,7,gr(1,6)-gr(3,6))
    gw(2,7,gr(2,6))
    gw(3,7,gr(4,6))
    sp();
    return 70
def _189():
    gw(7,7,0)
    gw(1,7,gr(1,6)-gr(2,6))
    gw(2,7,gr(3,6))
    gw(3,7,gr(4,6))
    sp();
    return 70
def _190():
    gw(7,7,0)
    gw(1,7,gr(1,6))
    gw(2,7,gr(2,6))
    gw(3,7,gr(4,6)+gr(3,6))
    sp();
    return 70
def _191():
    gw(7,7,0)
    gw(1,7,gr(1,6))
    gw(2,7,gr(3,6))
    gw(3,7,gr(4,6)+gr(2,6))
    sp();
    return 70
def _192():
    gw(7,7,0)
    gw(1,7,gr(3,6))
    gw(2,7,gr(2,6))
    gw(3,7,gr(4,6)+gr(1,6))
    sp();
    return 70
def _193():
    gw(7,7,0)
    gw(1,7,gr(1,6))
    gw(2,7,gr(2,6))
    gw(3,7,gr(3,6)+gr(4,6))
    sp();
    return 70
def _194():
    gw(7,7,0)
    gw(1,7,gr(1,6))
    gw(2,7,gr(4,6))
    gw(3,7,gr(3,6)+gr(2,6))
    sp();
    return 70
def _195():
    gw(7,7,0)
    gw(1,7,gr(4,6))
    gw(2,7,gr(2,6))
    gw(3,7,gr(3,6)+gr(1,6))
    sp();
    return 70
def _196():
    gw(7,7,0)
    gw(1,7,gr(1,6))
    gw(2,7,gr(2,6)+gr(4,6))
    gw(3,7,gr(3,6))
    sp();
    return 70
def _197():
    gw(7,7,0)
    gw(1,7,gr(1,6))
    gw(2,7,gr(2,6)+gr(3,6))
    gw(3,7,gr(4,6))
    sp();
    return 70
def _198():
    gw(7,7,0)
    gw(1,7,gr(4,6))
    gw(2,7,gr(2,6)+gr(1,6))
    gw(3,7,gr(3,6))
    sp();
    return 70
def _199():
    gw(7,7,0)
    gw(1,7,gr(1,6)+gr(4,6))
    gw(2,7,gr(2,6))
    gw(3,7,gr(3,6))
    sp();
    return 70
def _200():
    gw(7,7,0)
    gw(1,7,gr(1,6)+gr(3,6))
    gw(2,7,gr(2,6))
    gw(3,7,gr(4,6))
    sp();
    return 70
def _201():
    gw(7,7,0)
    gw(1,7,gr(1,6)+gr(2,6))
    gw(2,7,gr(3,6))
    gw(3,7,gr(4,6))
    sp();
    return 70
def _202():
    gw(4,0,gr(3,0)+1)
    gw(5,0,gr(4,0)+1)
    gw((gr(2,0)*10)+gr(3,0),(gr(5,0)*10)+gr(4,0),88)
    gw(3,1,gr(3,1)+1)
    return 3
def _203():
    gw(5,0,gr(4,0)+1)
    gw((gr(2,0)*10)+gr(3,0),(gr(5,0)*10)+gr(4,0),88)
    gw(3,1,gr(3,1)+1)
    return 3
def _204():
    gw((gr(2,0)*10)+gr(3,0),(gr(5,0)*10)+gr(4,0),88)
    gw(3,1,gr(3,1)+1)
    return 3
def _205():
    sa(sp()-1);
    return 1
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17,_18,_19,_20,_21,_22,_23,_24,_25,_26,_27,_28,_29,_30,_31,_32,_33,_34,_35,_36,_37,_38,_39,_40,_41,_42,_43,_44,_45,_46,_47,_48,_49,_50,_51,_52,_53,_54,_55,_56,_57,_58,_59,_60,_61,_62,_63,_64,_65,_66,_67,_68,_69,_70,_71,_72,_73,_74,_75,_76,_77,_78,_79,_80,_81,_82,_83,_84,_85,_86,_87,_88,_89,_90,_91,_92,_93,_94,_95,_96,_97,_98,_99,_100,_101,_102,_103,_104,_105,_106,_107,_108,_109,_110,_111,_112,_113,_114,_115,_116,_117,_118,_119,_120,_121,_122,_123,_124,_125,_126,_127,_128,_129,_130,_131,_132,_133,_134,_135,_136,_137,_138,_139,_140,_141,_142,_143,_144,_145,_146,_147,_148,_149,_150,_151,_152,_153,_154,_155,_156,_157,_158,_159,_160,_161,_162,_163,_164,_165,_166,_167,_168,_169,_170,_171,_172,_173,_174,_175,_176,_177,_178,_179,_180,_181,_182,_183,_184,_185,_186,_187,_188,_189,_190,_191,_192,_193,_194,_195,_196,_197,_198,_199,_200,_201,_202,_203,_204,_205]
c=0
while c<206:
    c=m[c]()
