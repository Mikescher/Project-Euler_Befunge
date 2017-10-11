#!/usr/bin/env python3

# transpiled with BefunCompile v1.2.0 (c) 2017
import gzip, base64
_g = ("AR+LCAAAAAAABACtkrFyhCAQhl+FQ6+RMbdy4kXCMCnyECkYTJEZWioqHz4/RM85c13UUWB32f32h8Q+85t/BzzVP54j6jP2fgTJyxEk4QgSOoLEj7WtWGXuhvTgTrtw"
  + "s9rMzlGzNPmq5d/ciU6vXmNrbrjtWq1HoYIbRRd15aearM6ma1BKnPE1ydJIUVotKSIJ3I2k0FZpqv180m0XlXh1baBboCFSv1XeLodxyzqhqK7Bg2Xem3FsrteFHkkH"
  + "iqU2CvSqaZobRbI3CgOFr9OsiixABzX9EpNbdPD3WvyNg6JhOpCMin9wiqYSq3dQy2TW4B4d6XgVo2E2I7QndLUJgpq5S8B0rSTPujUJrekg4gfvsiwEdSwiddNTZJu0"
  + "pRdWmkGDgPWRBoENwYiVfLKbZCkfFTQSRZoF8oz4yKi/YNTCJBA7cRFKhev+tMvVmJJ3ARu1NsTqPyEJ2aHJk52ZTqJxkrh79wi/Cy0JbRa6nZ/lWMZyN7IuNIpAYz6O"
  + "K+TCXDZgPxd+GB4AfwDY6hCc2gQAAA==")
g = base64.b64decode(_g)[1:]
for i in range(base64.b64decode(_g)[0]):
    g = gzip.decompress(g)
g=list(g)
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
    return (3)if(sp()!=0)else(27)
def _3():
    sa(sp()-1);

    sa(sr());
    sa((0)if(sp()!=0)else(1))

    return (5)if(sp()!=0)else(4)
def _4():
    sa(sr());
    sa(sr());
    sa(sp()*sp());

    sa(sp()-gr(2,0));
    return 2
def _5():
    gw(68,1,0)
    gw(68,3,0)
    gw(68,5,0)
    sp();
    sa(sr());
    sa(58)
    return 6
def _6():
    sa(sr());
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+9);

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
    sa(sp()+9);

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
    sa(sp()+9);

    sa(5)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr());

    return (35)if(sp()!=0)else(7)
def _7():
    sp();
    gw(68,1,sp())
    gw(2,0,0)
    gw(4,0,gr(2,0)*gr(2,0))
    sa(100)
    return 8
def _8():
    sa(59)
    sa(59)
    sa((gr(68,3)*gr(2,0)*20)+gr(4,0))
    gw(4,0,td((gr(68,3)*gr(2,0)*20)+gr(4,0),100))
    return 9
def _9():
    sa(tm(sp(),100))

    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+9);

    sa(5)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr());

    return (34)if(sp()!=0)else(10)
def _10():
    sp();
    sa(0)
    sa((0)if(gr(9,5)-gr(9,1)!=0)else(1))
    return 11
def _11():
    return (12)if(sp()!=0)else(15)
def _12():
    sa(sp()+1);


    return (13)if(sr()!=60)else(14)
def _13():
    global t0
    global t1
    sa(sr());
    sa(sr()+9)
    sa(5)
    v0=sp()
    t0=gr(sp(),v0)
    sa(sp()+9);

    sa(1)
    v0=sp()
    t1=gr(sp(),v0)
    sa(t0-t1)
    sa((0)if(sp()!=0)else(1))
    return 11
def _14():
    gw(2,0,gr(2,0)+1)
    gw(4,0,gr(2,0)*gr(2,0))
    sp();
    return 8
def _15():
    global t0
    global t1
    global t2
    sa(sr());
    sa(sr()+9)
    sa(5)
    v0=sp()
    t0=gr(sp(),v0)
    sa(sp()+9);

    sa(1)
    v0=sp()
    t1=gr(sp(),v0)
    t2=(1)if(t0>t1)else(0)
    t2=(0)if(t2!=0)else(1)

    return (14)if((t2)!=0)else(16)
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
    return (19)if(gr(7,0)<=gr(6,0))else(33)
def _19():
    global t0
    gw(4,0,t0)
    sa(gr(6,0)-gr(7,0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+8);

    sa(5)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sp()-1);

    sa(sr());
    sa((0)if(sp()!=0)else(1))

    return (21)if(sp()!=0)else(20)
def _20():
    global t0
    sa(sr());
    sa(sr()+9)
    sa(1)
    v0=sp()
    t0=gr(sp(),v0)
    t0=t0-gr(4,0)
    gw(6,0,t0)
    sa(sr()+9)
    sa(3)
    v0=sp()
    t0=gr(sp(),v0)
    t0=t0*gr(2,0)*20
    gw(7,0,t0)
    return 17
def _21():
    gw(68,1,gr(68,5))
    sp();
    sa(58)
    return 22
def _22():
    sa(sr());
    sa(sr()+9)
    sa(5)
    v0=sp()
    sa(gr(sp(),v0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+9);

    sa(1)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr());

    return (32)if(sp()!=0)else(23)
def _23():
    gw(9,3,((tm(gr(9,3),10))*10)+(td(gr(10,3),10)))
    sp();
    sa(1)
    return 24
def _24():
    global t0
    global t1
    sa(sr());
    sa(sr());
    sa(sr()+9)
    sa(3)
    v0=sp()
    t0=gr(sp(),v0)
    t0=tm(t0,10)
    t0=t0*10
    sa(sp()+10);

    sa(3)
    v0=sp()
    t1=gr(sp(),v0)
    t1=td(t1,10)
    sa(t0+t1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+9);

    sa(3)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sp()+1);
    return 25
def _25():
    return (24)if(sr()!=59)else(26)
def _26():
    gw(68,3,((tm(gr(68,3),10))*10)+gr(2,0))
    gw(9,0,gr(2,0)+gr(9,0))
    gw(2,0,0)
    sp();
    sa(sp()-1);

    sa(sr());
    sa((0)if(sp()!=0)else(1))

    return (27)if(sp()!=0)else(31)
def _27():
    sp();
    return 28
def _28():
    sa(sr()+1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()-100);


    return (29)if(sp()!=0)else(30)
def _29():
    sa(sr());
    gw(2,0,sp())
    return 1
def _30():
    print(gr(9,0),end=" ",flush=True)
    sp();
    return 36
def _31():
    gw(4,0,gr(2,0)*gr(2,0))
    return 8
def _32():
    sa(sp()-1);
    return 22
def _33():
    global t0
    gw(6,0,gr(6,0)+100)
    t0=t0+1
    return 18
def _34():
    global t0
    sa(sp()-1);

    sa(sr());
    sa(sr()+9)
    sa(3)
    v0=sp()
    sa(gr(sp(),v0))
    sa(sp()*gr(2,0)*20);

    sa(sp()+gr(4,0));

    t0=td(sr(),100)
    gw(4,0,t0)
    return 9
def _35():
    sa(sp()-1);
    return 6
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17,_18,_19,_20,_21,_22,_23,_24,_25,_26,_27,_28,_29,_30,_31,_32,_33,_34,_35]
c=0
while c<36:
    c=m[c]()
