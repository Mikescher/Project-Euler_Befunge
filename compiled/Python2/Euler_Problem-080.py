#!/usr/bin/env python2

# transpiled with BefunCompile v1.3.0 (c) 2017
import sys
import zlib, base64
_g = ("AR+LCAAAAAAABACtkrFyhCAQhl+FQ6+RMbdy4kXCMCnyECkYTJEZWioqHz4/RM85c13UUWB32f32h8Q+85t/BzzVP54j6jP2fgTJyxEk4QgSOoLEj7WtWGXuhvTgTrtw"
  + "s9rMzlGzNPmq5d/ciU6vXmNrbrjtWq1HoYIbRRd15aearM6ma1BKnPE1ydJIUVotKSIJ3I2k0FZpqv180m0XlXh1baBboCFSv1XeLodxyzqhqK7Bg2Xem3FsrteFHkkH"
  + "iqU2CvSqaZobRbI3CgOFr9OsiixABzX9EpNbdPD3WvyNg6JhOpCMin9wiqYSq3dQy2TW4B4d6XgVo2E2I7QndLUJgpq5S8B0rSTPujUJrekg4gfvsiwEdSwiddNTZJu0"
  + "pRdWmkGDgPWRBoENwYiVfLKbZCkfFTQSRZoF8oz4yKi/YNTCJBA7cRFKhev+tMvVmJJ3ARu1NsTqPyEJ2aHJk52ZTqJxkrh79wi/Cy0JbRa6nZ/lWMZyN7IuNIpAYz6O"
  + "K+TCXDZgPxd+GB4AfwDY6hCc2gQAAA==")
g = base64.b64decode(_g)[1:]
for i in range(ord(base64.b64decode(_g)[0])):
    g = zlib.decompress(g, 16+zlib.MAX_WBITS)
g=list(map(ord, g))
def gr(x,y):
    if(x>=0 and y>=0 and x<69 and y<18):
        return g[y*69 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<69 and y<18):
        g[y*69 + x]=v;
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
    gw(9,0,0)
    gw(2,0,2)
    sa(2)
    return 1
def _1():
    sa(100)
    sa(10000-gr(2,0))
    return 2
def _2():
    return (3)if(sp()!=0)else(26)
def _3():
    sa(sp()-1)

    sa(sr());

    return (4)if(sp()!=0)else(5)
def _4():
    sa(sr());
    sa(sr());
    sa(sp()*sp());

    sa(sp()-gr(2,0))
    return 2
def _5():
    gw(68,1,0)
    gw(68,3,0)
    gw(68,5,0)
    sp();
    sa(sr());
    sa(59)
    sa(59)
    return 6
def _6():
    return (34)if(sp()!=0)else(7)
def _7():
    sp();
    gw(68,1,sp())
    gw(2,0,0)
    sa(100)
    return 8
def _8():
    global t0
    gw(4,0,gr(2,0)*gr(2,0))
    t0=((gr(68,3)*gr(2,0)*20)+gr(4,0))%100
    gw(4,0,((gr(68,3)*gr(2,0)*20)+gr(4,0))/100)
    gw(68,5,t0)
    sa(59)
    sa(59)
    return 9
def _9():
    return (33)if(sp()!=0)else(10)
def _10():
    sp();
    sa(0)
    sa(gr(9,5)-gr(9,1))
    return 11
def _11():
    return (15)if(sp()!=0)else(12)
def _12():
    sa(sp()+1)


    return (13)if(sr()!=60)else(14)
def _13():
    global t0
    global t1
    sa(sr());
    t0=gr(sr()+9,5)
    sa(sp()+9)

    sa(1)
    v0=sp()
    t1=gr(sp(),v0)
    sa(t0-t1)
    return 11
def _14():
    gw(2,0,gr(2,0)+1)
    sp();
    return 8
def _15():
    global t0
    global t1
    global t2
    sa(sr());
    t0=gr(sr()+9,5)
    sa(sp()+9)

    sa(1)
    v0=sp()
    t1=gr(sp(),v0)
    t2=(1)if(t0>t1)else(0)

    return (16)if((t2)!=0)else(14)
def _16():
    gw(2,0,gr(2,0)-1)
    gw(68,5,0)
    gw(4,0,gr(2,0)*gr(2,0))
    gw(6,0,gr(68,1)-gr(4,0))
    gw(7,0,gr(68,3)*gr(2,0)*20)
    sp();
    sa(59)
    sa(59)
    return 17
def _17():
    global t0
    t0=0
    return 18
def _18():
    return (32)if(gr(7,0)>gr(6,0))else(19)
def _19():
    global t0
    gw(4,0,t0)
    sa(gr(6,0)-gr(7,0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+8)

    sa(5)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sp()-1)

    sa(sr());

    return (20)if(sp()!=0)else(21)
def _20():
    sa(sr());
    gw(6,0,gr(sr()+9,1)-gr(4,0))
    gw(7,0,gr(sr()+9,3)*gr(2,0)*20)
    return 17
def _21():
    gw(68,1,gr(68,5))
    sp();
    sa(59)
    sa(59)
    return 22
def _22():
    return (31)if(sp()!=0)else(23)
def _23():
    gw(9,3,((gr(9,3)%10)*10)+(gr(10,3)/10))
    sp();
    sa(1)
    sa(-58)
    return 24
def _24():
    return (30)if(sp()!=0)else(25)
def _25():
    gw(68,3,((gr(68,3)%10)*10)+gr(2,0))
    gw(9,0,gr(2,0)+gr(9,0))
    gw(2,0,0)
    sp();
    sa(sp()-1)

    sa(sr());

    return (8)if(sp()!=0)else(26)
def _26():
    sp();
    return 27
def _27():
    sa(sr()+1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()-100)


    return (28)if(sp()!=0)else(29)
def _28():
    sa(sr());
    gw(2,0,sp())
    return 1
def _29():
    sys.stdout.write(str(gr(9,0))+" ")
    sys.stdout.flush()

    sp();
    return 35
def _30():
    global t0
    global t1
    sa(sr());
    sa(sr());
    t0=(gr(sr()+9,3)%10)*10
    sa(sp()+10)

    sa(3)
    v0=sp()
    t1=gr(sp(),v0)
    t1=t1/10
    sa(t0+t1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+9)

    sa(3)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sp()+1)

    sa(sr()-59)
    return 24
def _31():
    sa(sp()-1)

    sa(sr());
    sa(gr(sr()+9,5))
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
    return 22
def _32():
    global t0
    gw(6,0,gr(6,0)+100)
    t0=t0+1
    return 18
def _33():
    sa(sp()-1)

    sa(sr());
    sa((gr(sr()+9,3)*gr(2,0)*20)+gr(4,0))
    gw(4,0,sr()/100)
    sa(sp()%100);

    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+9)

    sa(5)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr());
    return 9
def _34():
    sa(sp()-1)

    sa(sr());
    sa(0)
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
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+9)

    sa(3)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr());
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+9)

    sa(5)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr());
    return 6
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17,_18,_19,_20,_21,_22,_23,_24,_25,_26,_27,_28,_29,_30,_31,_32,_33,_34]
c=0
while c<35:
    c=m[c]()
