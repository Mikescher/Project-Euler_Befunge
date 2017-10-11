#!/usr/bin/env python3

# transpiled with BefunCompile v1.2.0 (c) 2017
import gzip, base64
_g = ("Ah+LCAAAAAAABACT7+ZgAAEWhrd3z/Y1GQgc+BiuyCV+Qs95Kafispvshq8SJ8dVPzpy+D3DbqGJL3YVltr/23+kRGexwtLL93KU/qh4MxAPdkx0/x+vve7ZrP4HBlW+"
  + "4mvliy3rZ0fv0Tu1RU9lzRrfyyEqHRXhNle3XixI/rSrVOqX76Y7715Nbckxlbm+vbD4J8uOxm18kROrNffMUJG6tXffsuAmzaJsdf8KGa6Ji3+/4Qvc2Dvre+OpPRH6"
  + "qUZtMz177G1PTIhVnVe2Y6eUyfVKu43Zvxd+iN+/7f+Jl1mBXgVLK2KFTbJ+B9QYmey0e6MmaWW8unOb/5bYRbJCb00CrY3+3qq9PddB7i93/dK3Pw8nX/yZknSH9e+N"
  + "mB8MfXNF5t6ssi8PjpTY1zx51f2Hr55dm7lOJDOhzSrlmNUU/dmy1bets0udrV9Gsa8s2Zyyx0X088NzMar/fj5dkb0muOdY7R7GFXMF1Rs6GRgAPr8OZ4ABAAA=")
g = base64.b64decode(_g)[1:]
for i in range(base64.b64decode(_g)[0]):
    g = gzip.decompress(g)
g=list(g)
def gr(x,y):
    if(x>=0 and y>=0 and x<400 and y<88):
        return g[y*400 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<400 and y<88):
        g[y*400 + x]=v;
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
    gw(1,0,400)
    gw(0,0,30000)
    sa(gr(0,0)-1)
    sa(gr(0,0)-1)
    gw(2,0,gr(0,0)-1)
    return 1
def _1():
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),2))

    sa(sr());

    return (2)if(sp()!=0)else(22)
def _2():
    global t0
    global t1
    sa(sr());
    t0=gr(2,0)
    sa(t0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    v0=sp()
    sa(tm(sp(),v0))

    t1=sp()

    return (21)if((t1)!=0)else(3)
def _3():
    sa(sr());
    gw(3,0,sp())
    sa(sp()+sp());

    sa(gr(3,0)-1)
    sa(gr(3,0)-1)
    return 4
def _4():
    return (2)if(sp()!=0)else(5)
def _5():
    sp();
    sa((1)if(sp()>gr(2,0))else(0))

    gw(tm(gr(2,0),gr(1,0)),(td(gr(2,0),gr(1,0)))+1,sp())
    return 6
def _6():
    sa(sr());

    return (20)if(sp()!=0)else(7)
def _7():
    gw(0,1,0)
    gw(4,0,gr(0,0))
    sp();
    sp();
    return 8
def _8():
    sa(gr(4,0)-1)
    gw(4,0,gr(4,0)-1)

    return (14)if(sp()!=0)else(9)
def _9():
    gw(8,0,0)
    gw(2,0,gr(0,0))
    return 10
def _10():
    gw(2,0,gr(2,0)-1)

    return (12)if(td(gr(tm(gr(2,0),gr(1,0)),(td(gr(2,0),gr(1,0)))+1),2)!=0)else(11)
def _11():
    gw(8,0,gr(8,0)+gr(2,0))
    return 12
def _12():
    return (10)if((gr(2,0))!=0)else(13)
def _13():
    print(gr(8,0),end=" ",flush=True)
    return 23
def _14():
    return (15)if(tm(gr(tm(gr(4,0),gr(1,0)),(td(gr(4,0),gr(1,0)))+1),2)!=0)else(8)
def _15():
    gw(5,0,gr(4,0)+1)
    return 16
def _16():
    sa(gr(5,0)-1)
    gw(5,0,gr(5,0)-1)

    return (17)if(sp()!=0)else(8)
def _17():
    return (18)if(tm(gr(tm(gr(5,0),gr(1,0)),(td(gr(5,0),gr(1,0)))+1),2)!=0)else(16)
def _18():
    return (16)if((gr(4,0)+gr(5,0))>gr(0,0))else(19)
def _19():
    gw(tm(gr(4,0)+gr(5,0),gr(1,0)),(td(gr(4,0)+gr(5,0),gr(1,0)))+1,(tm(gr(tm(gr(4,0)+gr(5,0),gr(1,0)),(td(gr(4,0)+gr(5,0),gr(1,0)))+1),2))+2)
    return 16
def _20():
    sa(sp()-1);

    sa(sr());
    sa(sr());
    gw(2,0,sp())
    return 1
def _21():
    sa(sp()-1);

    sa(sr());
    return 4
def _22():
    gw(tm(gr(2,0),gr(1,0)),(td(gr(2,0),gr(1,0)))+1,(1)if(1>gr(2,0))else(0))
    return 6
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17,_18,_19,_20,_21,_22]
c=0
while c<23:
    c=m[c]()
