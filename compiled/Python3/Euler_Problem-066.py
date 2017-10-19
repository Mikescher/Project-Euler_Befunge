#!/usr/bin/env python3

# transpiled with BefunCompile v1.3.0 (c) 2017
import gzip, base64
_g = ("AR+LCAAAAAAABADdVMGO4yAM/RW3yV5AbDGQNkEIjfYDttfOKEr3xpUTp+6/r03SadrRaKRqTmspNQXbvPfspLy+vgJb82DwpJ1+nU7fWe/t7e1b8f1+NvETOx6P1X8X"
  + "vqv9R/UKDN5nJ4cxdZKXyEtDSwjP1Ityn8ZBdtmjGjdFw6rMM/VmjIu1Z+8HiXyBzn76Iq0mnkujxPbvts9oPaWibR8AzbfzZty+wNYLL4TBbC1mjTb3Pcjoe6nHvuKI"
  + "iOnnS2XazyQvtFbGpJ0x2XZiWl+/WNbGUzVN14c2nKdm4xXmeyDTorsPDUzCJ8Ngs0FFK5HAmFCoRNKWKSWNnj2EtQqh0F4trUcte2rmqClCdDZjpX6+3QaQorcko9GQ"
  + "xp00Ow9Wp1W5eKNO7WTn2NWIWCP+LNGxbaEt5j3x6lsq6B1mLywmxTq1uHcCM/86YmMykmikk+Yj6QfVq5pKomo7rWSj9tXu3bG93tOAbaBrQNReNnQwkcZepV6+iwqh"
  + "LSyEsbtkjKzyuvtJuPajha+NOE7R8zhqHkdM1iQh0SbpCzW+s6vmXjajQp+cuY5e5LwD5w1JLTH8cFgmuOOPhAayxR37QCMaZ0waHY0YiMj3jlAuGzUkZ6nhB3Kcld2c"
  + "5GUKpH8nKkZX38kbxrIiGUU0wGVFBWZckg3slXV5kCbRX3YlYjnEz2pBeKA4MzlcNXh8UxvWWqU5ar/wXej6EJeYyrFcgDjCTHK4J0kceScUFOEyBkcjhAuRtU0ris0Q"
  + "gTgCkVwo7meK+0QjKgTSwRTpGKT97PtS92m+KvoAU/fhk/Ixo0b8A6X0qdzQBwAA")
g = base64.b64decode(_g)[1:]
for i in range(base64.b64decode(_g)[0]):
    g = gzip.decompress(g)
g=list(g)
def gr(x,y):
    if(x>=0 and y>=0 and x<80 and y<25):
        return g[y*80 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<80 and y<25):
        g[y*80 + x]=v;
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
    gw(2,1,67108864)
    gw(3,1,3)
    gw(1,3,0)
    gw(24,8,0)
    sa(15)
    sa(15)
    return 1
def _1():
    return (55)if(sp()!=0)else(2)
def _2():
    sp();
    return 3
def _3():
    global t0
    t0=gr(3,1)
    sa(gr(3,1))
    sa(gr(3,1))
    gw(1,0,0)
    gw(2,0,t0)
    return 4
def _4():
    global t0
    global t1
    gw(3,0,sp())
    t0=gr(2,0)
    sa(sr());
    sa(t0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    v0=sp()
    sa(td(sp(),v0))

    t1=sp()
    sa(sp()+t1)

    sa(sp()/2);


    return (53)if((sr()-gr(3,0))!=0)else(5)
def _5():
    global t0
    t0=gr(3,0)*gr(3,0)
    gw(4,1,gr(3,0))
    t0=t0-gr(3,1)
    sp();

    return (6)if((t0)!=0)else(52)
def _6():
    gw(24,5,0)
    gw(24,4,0)
    gw(24,1,0)
    gw(24,0,0)
    sa(15)
    sa(15)
    return 7
def _7():
    return (51)if(sp()!=0)else(8)
def _8():
    gw(24,1,1)
    gw(24,4,1)
    gw(1,2,0)
    gw(2,2,1)
    sp();
    return 9
def _9():
    gw(3,2,td(gr(4,1)+gr(1,2),gr(2,2)))
    sa(15)
    sa(15)
    sa(gr(24,0)+(gr(24,1)*gr(3,2))+gr(1,3))
    gw(1,3,td(gr(24,0)+(gr(24,1)*gr(3,2))+gr(1,3),gr(2,1)))
    return 10
def _10():
    sa(tm(sp(),gr(2,1)))

    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+9)

    sa(2)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr()-1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)

    return (50)if(sp()!=0)else(11)
def _11():
    sp();
    sa(15)
    sa(15)
    sa(gr(24,4)+(gr(24,5)*gr(3,2))+gr(1,3))
    gw(1,3,td(gr(24,4)+(gr(24,5)*gr(3,2))+gr(1,3),gr(2,1)))
    return 12
def _12():
    sa(tm(sp(),gr(2,1)))

    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+9)

    sa(6)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr()-1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)

    return (13)if(sp()!=0)else(14)
def _13():
    global t0
    global t1
    sa(sr());
    sa(sr());
    t0=gr(sr()+9,4)
    sa(sp()+9)

    sa(5)
    v0=sp()
    t1=gr(sp(),v0)
    t1=t1*gr(3,2)
    sa(t0+t1+gr(1,3))
    gw(1,3,td(sr(),gr(2,1)))
    return 12
def _14():
    gw(1,4,1)
    gw(24,9,0)
    sp();
    sa(14)
    sa(15)
    return 15
def _15():
    return (49)if(sp()!=0)else(16)
def _16():
    gw(2,4,15)
    sp();
    return 17
def _17():
    gw(3,4,gr(2,4)+9)
    sa(15)
    sa((gr(24,6)*gr(gr(2,4)+9,6)*gr(3,1))+gr(1,4)+gr(gr(3,4),9))
    gw(1,4,td((gr(24,6)*gr(gr(2,4)+9,6)*gr(3,1))+gr(1,4)+gr(gr(3,4),9),gr(2,1)))
    return 18
def _18():
    sa(tm(sp(),gr(2,1)))

    gw(gr(3,4),9,sp())
    sa(sp()-1)


    return (48)if(gr(3,4)!=9)else(19)
def _19():
    global t0
    t0=gr(2,4)-1
    sp();

    return (47)if((gr(2,4))!=0)else(20)
def _20():
    gw(1,4,0)
    gw(24,7,0)
    sa(14)
    sa(15)
    return 21
def _21():
    return (46)if(sp()!=0)else(22)
def _22():
    gw(2,4,15)
    sp();
    return 23
def _23():
    gw(3,4,gr(2,4)+9)
    sa(15)
    sa((gr(24,2)*gr(gr(2,4)+9,2))+gr(1,4)+gr(gr(3,4),7))
    gw(1,4,td((gr(24,2)*gr(gr(2,4)+9,2))+gr(1,4)+gr(gr(3,4),7),gr(2,1)))
    return 24
def _24():
    sa(tm(sp(),gr(2,1)))

    gw(gr(3,4),7,sp())
    sa(sp()-1)


    return (45)if(gr(3,4)!=9)else(25)
def _25():
    global t0
    t0=gr(2,4)-1
    sp();

    return (44)if((gr(2,4))!=0)else(26)
def _26():
    sa(15)
    sa(gr(24,7)-gr(24,9))
    return 27
def _27():
    return (40)if(sp()!=0)else(28)
def _28():
    sa(sr()-1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)

    return (29)if(sp()!=0)else(30)
def _29():
    global t0
    global t1
    sa(sr());
    t0=gr(sr()+9,7)
    sa(sp()+9)

    sa(9)
    v0=sp()
    t1=gr(sp(),v0)
    sa(t0-t1)
    return 27
def _30():
    global t0
    global t1
    t0=1
    t1=1
    sp();
    sa(0)
    sa(gr(9,2)-gr(9,8))
    sa(gr(9,2)-gr(9,8))
    return 31
def _31():
    return (36)if(sp()!=0)else(32)
def _32():
    sp();
    sa(sp()+1)


    return (35)if(sr()!=17)else(33)
def _33():
    global t0
    t0=gr(3,1)-999
    gw(3,1,gr(3,1)+1)
    sp();

    return (3)if((t0)!=0)else(34)
def _34():
    print(gr(1,1),end=" ",flush=True)
    return 56
def _35():
    global t0
    global t1
    sa(sr());
    t0=gr(sr()+9,2)
    sa(sp()+9)

    sa(8)
    v0=sp()
    t1=gr(sp(),v0)
    sa(t0-t1)
    sa(t0-t1)
    return 31
def _36():
    sa((1)if(sp()>0)else(0))


    return (37)if(sp()!=0)else(33)
def _37():
    gw(1,1,gr(3,1))
    gw(24,8,gr(24,2))
    sp();
    sa(14)
    sa(15)
    return 38
def _38():
    return (39)if(sp()!=0)else(33)
def _39():
    sa(sr());
    sa(gr(sr()+9,2))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+9)

    sa(8)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr()-1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    return 38
def _40():
    gw(1,2,(gr(3,2)*gr(2,2))-gr(1,2))
    gw(2,2,td(gr(3,1)-(gr(1,2)*gr(1,2)),gr(2,2)))
    sp();
    sa(15)
    sa(0)
    return 41
def _41():
    return (42)if(sp()!=0)else(43)
def _42():
    sp();
    return 9
def _43():
    sa(sr());
    sa(gr(sr()+9,1))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+9)

    sa(0)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr());
    sa(gr(sr()+9,2))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+9)

    sa(1)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr());
    sa(gr(sr()+9,5))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+9)

    sa(4)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr());
    sa(gr(sr()+9,6))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+9)

    sa(5)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr()-1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa((0)if(sp()!=0)else(1))
    return 41
def _44():
    global t0
    gw(2,4,t0)
    return 23
def _45():
    sa(sr());
    gw(3,4,(sr()+gr(2,4))-6)
    sa(sp()+9)

    sa(2)
    v0=sp()
    sa(gr(sp(),v0))
    sa(sp()*gr(gr(2,4)+9,2))

    sa(sp()+gr(1,4))

    sa(sp()+gr(gr(3,4),7))

    gw(1,4,td(sr(),gr(2,1)))
    return 24
def _46():
    sa(sr()+9)
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(7)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr()-1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    return 21
def _47():
    global t0
    gw(2,4,t0)
    return 17
def _48():
    sa(sr());
    gw(3,4,(sr()+gr(2,4))-6)
    sa(sp()+9)

    sa(6)
    v0=sp()
    sa(gr(sp(),v0))
    sa(sp()*gr(gr(2,4)+9,6)*gr(3,1))

    sa(sp()+gr(1,4))

    sa(sp()+gr(gr(3,4),9))

    gw(1,4,td(sr(),gr(2,1)))
    return 18
def _49():
    sa(sr()+9)
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(9)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr()-1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    return 15
def _50():
    global t0
    global t1
    sa(sr());
    sa(sr());
    t0=gr(sr()+9,0)
    sa(sp()+9)

    sa(1)
    v0=sp()
    t1=gr(sp(),v0)
    t1=t1*gr(3,2)
    sa(t0+t1+gr(1,3))
    gw(1,3,td(sr(),gr(2,1)))
    return 10
def _51():
    sa(sr()+8)
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(5)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr()+8)
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(4)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr()+8)
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(1)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr()+8)
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(0)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sp()-1)

    sa(sr());
    return 7
def _52():
    global t0
    gw(3,1,gr(3,1)+1)
    t0=gr(3,1)
    sa(gr(3,1))
    sa(gr(3,1))
    gw(1,0,0)
    gw(2,0,t0)
    return 4
def _53():
    return (54)if((sr()-gr(1,0))!=0)else(5)
def _54():
    gw(1,0,gr(3,0))
    sa(sr());
    return 4
def _55():
    sa(sr()+8)
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(8)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sp()-1)

    sa(sr());
    return 1
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17,_18,_19,_20,_21,_22,_23,_24,_25,_26,_27,_28,_29,_30,_31,_32,_33,_34,_35,_36,_37,_38,_39,_40,_41,_42,_43,_44,_45,_46,_47,_48,_49,_50,_51,_52,_53,_54,_55]
c=0
while c<56:
    c=m[c]()
