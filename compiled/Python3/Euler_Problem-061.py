#!/usr/bin/env python3

# transpiled with BefunCompile v1.3.0 (c) 2017
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
    sa(gr(1,0)-1)
    gw((gr(2,0)%64)+9,((gr(1,0)-1)*2)+(gr(2,0)/64),0)
    return 2
def _2():
    return (34)if(sp()!=0)else(3)
def _3():
    sp();

    return (1)if((gr(2,0))!=0)else(4)
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
    return (7)if(sp()!=0)else(8)
def _7():
    global t0
    global t1
    sp();
    sa(sp()+1)

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
    t1=t1/2
    t1=t1*(gr(2,0)+1)
    sa(sp()+t1)

    sa((1)if(sr()<1000)else(0))
    return 6
def _8():
    return (9)if(sr()>9999)else(33)
def _9():
    sp();
    sp();

    return (5)if((gr(2,0))!=0)else(10)
def _10():
    sa(gr(1,0)-1)
    sa(0)
    sa(6)
    sa(gr(1,0)-1)
    gw(5,gr(1,0)-1,0)
    return 11
def _11():
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

    return (12)if(sp()!=0)else(32)
def _12():
    sa(sr());
    sa((0)if(sp()!=0)else(1))
    return 13
def _13():
    return (14)if(sp()!=0)else(31)
def _14():
    sp();
    return 15
def _15():
    gw(6,gr(1,1),gr(6,gr(1,1))+1)
    gw(1,2,gr(6,gr(1,1)))
    gw(1,3,gr(5,gr(1,1)))

    return (17)if((gr(1,2)-gr(1,0))!=0)else(16)
def _16():
    gw(6,gr(1,1),-1)
    gw(5,gr(1,1),gr(5,gr(1,1))+1)
    return 15
def _17():
    return (18)if(gr(1,3)>127)else(19)
def _18():
    global t0
    gw(1,1,gr(1,1)-1)
    gw(7,gr(6,gr(1,1)),0)
    t0=9
    return 15
def _19():
    return (21)if((gr(7,gr(1,2)))!=0)else(20)
def _20():
    gw(1,4,gr((gr(1,3)%64)+9,(gr(1,3)/64)+(gr(1,2)*2)))

    return (22)if((gr(1,4))!=0)else(21)
def _21():
    sa(0)
    sa(1)
    return 13
def _22():
    return (21)if((gr(1,1)*((gr((gr(5,gr(1,1)-1)%64)+9,(gr(5,gr(1,1)-1)/64)+(gr(6,gr(1,1)-1)*2))%100)-(gr(1,4)/100)))!=0)else(23)
def _23():
    return (24)if((gr(1,0)-1)>gr(1,1))else(25)
def _24():
    gw(7,gr(1,2),1)
    gw(1,1,gr(1,1)+1)
    gw(6,gr(1,1),-1)
    gw(5,gr(1,1),0)
    return 15
def _25():
    return (30)if(((gr(1,4)%100)-(gr((gr(5,0)%64)+9,(gr(5,0)/64)+(gr(6,0)*2))/100))!=0)else(26)
def _26():
    global t0
    gw(2,1,0)
    print(gr((gr(5,gr(2,1))%64)+9,(gr(5,gr(2,1))/64)+(gr(6,gr(2,1))*2)),end=" ",flush=True)
    print(chr(10),end="",flush=True)
    t0=gr((gr(5,gr(2,1))%64)+9,(gr(5,gr(2,1))/64)+(gr(6,gr(2,1))*2))
    return 27
def _27():
    global t1
    t1=gr(2,1)+1
    gw(2,1,gr(2,1)+1)
    t1=t1-gr(1,0)

    return (29)if((t1)!=0)else(28)
def _28():
    global t0
    print("  = ",end="",flush=True)
    print(t0,end=" ",flush=True)
    return 35
def _29():
    global t0
    print(gr((gr(5,gr(2,1))%64)+9,(gr(5,gr(2,1))/64)+(gr(6,gr(2,1))*2)),end=" ",flush=True)
    print(chr(10),end="",flush=True)
    t0=t0+gr((gr(5,gr(2,1))%64)+9,(gr(5,gr(2,1))/64)+(gr(6,gr(2,1))*2))
    return 27
def _30():
    global t0
    global t1
    t0=0
    t1=4
    return 21
def _31():
    sa(sp()-1)

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
    return 11
def _32():
    gw(6,0,-1)
    gw(1,1,0)
    sp();
    return 21
def _33():
    gw((gr(3,0)%64)+9,(gr(3,0)/64)+(gr(2,0)*2),sp())
    gw(3,0,gr(3,0)+1)
    sa(0)
    return 7
def _34():
    sa(sp()-1)

    sa(sr());
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()*2)

    sa(sp()+(gr(2,0)/64))

    sa((gr(2,0)%64)+9)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr());
    return 2
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17,_18,_19,_20,_21,_22,_23,_24,_25,_26,_27,_28,_29,_30,_31,_32,_33,_34]
c=0
while c<35:
    c=m[c]()
