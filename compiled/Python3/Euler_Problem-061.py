#!/usr/bin/env python3

# transpiled with BefunCompile v1.2.0 (c) 2017
import gzip, base64
_g = ("AR+LCAAAAAAABADtU8uO2zAM/BVGdi7Sak3KseM1VKMfYjgB2kJXnXxq/71DO8kmu8kCRXvrEpBEvUbDITWXJVFRFOT/0hYQ2D/Ho/8Ljz7xPvH+EG+1+TAXm9cpZnTf"
  + "oqxj4lCW8e1uUZyQhWaizCGxLMjFekP9Po/uZWu7DgsU+cE7agOutWjCGbPQddZS4DwETuLhCKdBfM9jsFjCduWmicrImWsniWvKzoJCqPS1eM2P6YLCNdogrofZ0YdK"
  + "N5x1vfllOjsei+nQmx/fjFWvXt7ZvriapxuqJybNmNG3S79HX8wHfHIW3+IRkayyPLT5Vc/yMEGpe/q/ESxe9RhvcjK0Igmx6JBXP+RmGessIUE/vwFDqZM5kHFH+Hus"
  + "JwSKNQRKiHT1KgnzFHMSaZwCSKN+6+VdAuMMsb0sJ9c8rxM0BJV2kneSNC9R8RRkj1TKcuiuLPZSi2WceQU9r6CImq35bgD7rhgf2VCpFuJTsC7h7lZ2OlTeatxaFdg+"
  + "bn7SKV4+RwqWTlnmFGR/n+sHFlFyeLB/dk3jngKAXB9Ei9hDd0NfiMwT7PnrNVeVvuUz1cqD4qWEJk1ouxQ3nLPa6uILSPjoa90SO9lvqywlwdAHAAA=")
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
    gw(1,0,6)
    gw(2,0,128)
    return 1
def _1():
    gw(2,0,gr(2,0)-1)
    sa(gr(1,0)-1)
    gw((tm(gr(2,0),64))+9,((gr(1,0)-1)*2)+(td(gr(2,0),64)),0)
    return 2
def _2():
    sa(sr());
    sa((0)if(sp()!=0)else(1))

    return (3)if(sp()!=0)else(33)
def _3():
    sp();

    return (4)if((gr(2,0))==0)else(1)
def _4():
    gw(2,0,gr(1,0))
    return 5
def _5():
    gw(2,0,gr(2,0)-1)
    gw(3,0,0)
    sa(1)
    sa(1+(0*(gr(2,0)+1)))
    sa((1)if((1+(0*(gr(2,0)+1)))<1000)else(0))
    return 6
def _6():
    return (7)if(sp()!=0)else(9)
def _7():
    sp();
    return 8
def _8():
    global t0
    global t1
    sa(sp()+1);

    sa(sr());
    sa(sr());
    sa(sr());
    sa(sr());
    sa(sp()*sp());

    t0=sp()
    sa(t0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    v0=sp()
    sa(sp()-v0)

    t1=sp()
    t1=td(t1,2)
    t1=t1*(gr(2,0)+1)
    sa(sp()+t1);

    sa((1)if(sr()<1000)else(0))
    return 6
def _9():
    return (10)if(sr()>9999)else(32)
def _10():
    sp();
    sp();

    return (11)if((gr(2,0))==0)else(5)
def _11():
    sa(gr(1,0)-1)
    gw(5,gr(1,0)-1,0)
    return 12
def _12():
    sa(sr());
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(6)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr());
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(7)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr());

    return (13)if(sp()!=0)else(31)
def _13():
    sa(sr());
    sa((0)if(sp()!=0)else(1))

    return (15)if(sp()!=0)else(14)
def _14():
    sa(sp()-1);

    sa(sr());
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(5)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    return 12
def _15():
    gw(6,gr(1,1),gr(6,gr(1,1))+1)
    gw(1,2,gr(6,gr(1,1)))
    gw(1,3,gr(5,gr(1,1)))
    sp();
    return 16
def _16():
    return (17)if(gr(1,2)-gr(1,0)==0)else(18)
def _17():
    gw(6,gr(1,1),-1)
    gw(5,gr(1,1),gr(5,gr(1,1))+1)
    gw(6,gr(1,1),gr(6,gr(1,1))+1)
    gw(1,2,gr(6,gr(1,1)))
    gw(1,3,gr(5,gr(1,1)))
    return 16
def _18():
    return (19)if(gr(1,3)>127)else(20)
def _19():
    gw(1,1,gr(1,1)-1)
    gw(7,gr(6,gr(1,1)),0)
    gw(6,gr(1,1),gr(6,gr(1,1))+1)
    gw(1,2,gr(6,gr(1,1)))
    gw(1,3,gr(5,gr(1,1)))
    return 16
def _20():
    return (22)if((gr(7,gr(1,2)))!=0)else(21)
def _21():
    gw(1,4,gr((tm(gr(1,3),64))+9,(td(gr(1,3),64))+(gr(1,2)*2)))

    return (23)if((gr(1,4))!=0)else(22)
def _22():
    sa(0)
    return 15
def _23():
    return (22)if((gr(1,1)*((tm(gr((tm(gr(5,gr(1,1)-1),64))+9,(td(gr(5,gr(1,1)-1),64))+(gr(6,gr(1,1)-1)*2)),100))-(td(gr(1,4),100))))!=0)else(24)
def _24():
    return (26)if((gr(1,0)-1)<=gr(1,1))else(25)
def _25():
    gw(7,gr(1,2),1)
    gw(1,1,gr(1,1)+1)
    gw(6,gr(1,1),-1)
    gw(5,gr(1,1),0)
    gw(6,gr(1,1),gr(6,gr(1,1))+1)
    gw(1,2,gr(6,gr(1,1)))
    gw(1,3,gr(5,gr(1,1)))
    return 16
def _26():
    return (22)if((tm(gr(1,4),100))!=(td(gr((tm(gr(5,0),64))+9,(td(gr(5,0),64))+(gr(6,0)*2)),100)))else(27)
def _27():
    global t2
    gw(2,1,0)
    t2=0
    return 28
def _28():
    global t0
    global t2
    t0=gr((tm(gr(5,gr(2,1)),64))+9,(td(gr(5,gr(2,1)),64))+(gr(6,gr(2,1))*2))
    print(gr((tm(gr(5,gr(2,1)),64))+9,(td(gr(5,gr(2,1)),64))+(gr(6,gr(2,1))*2)),end=" ",flush=True)
    print(chr(10),end="",flush=True)
    t2=t2+t0
    t0=gr(2,1)+1
    gw(2,1,gr(2,1)+1)
    t0=t0-gr(1,0)
    return 29
def _29():
    global t0
    return (28)if((t0)!=0)else(30)
def _30():
    global t2
    print("  = ",end="",flush=True)
    print(t2,end=" ",flush=True)
    return 34
def _31():
    gw(6,0,-1)
    gw(1,1,0)
    sp();
    return 22
def _32():
    gw((tm(gr(3,0),64))+9,(td(gr(3,0),64))+(gr(2,0)*2),sp())
    gw(3,0,gr(3,0)+1)
    return 8
def _33():
    sa(sp()-1);

    sa(sr());
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()*2);

    sa(sp()+(td(gr(2,0),64)));

    sa((tm(gr(2,0),64))+9)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    return 2
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17,_18,_19,_20,_21,_22,_23,_24,_25,_26,_27,_28,_29,_30,_31,_32,_33]
c=0
while c<34:
    c=m[c]()
