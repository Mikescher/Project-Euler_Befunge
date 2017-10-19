#!/usr/bin/env python3

# transpiled with BefunCompile v1.3.0 (c) 2017
import gzip, base64
_g = ("AR+LCAAAAAAABADtUbsOgzAM/JXwWhpRnAEGy4r6IVFBaqWsTJn4+NpFPAW0Hdh6g2X5nPPFjp+xgRYAWmvAI4DXnJsck1CnwJSNH7EwaDReHJaoM8ehqHTbcI/qEWx6"
  + "vfXpXc3QgqGN8sRq48EoGirwjnajd41wTHcROup4QG6QJ1Ca1iGJ0Ouq0Fi6jIPUFZK44D9qkgbOMRdLJJkHcmKdFtK22TDIqzh0NL1YtIV87Wg2y/I1hnxYXzLimyXN"
  + "X678jljaBLn1/Mgf9ryj8zNWOtumBaRolzvPz1/nJJ0XFH7TnYAEAAA=")
g = base64.b64decode(_g)[1:]
for i in range(base64.b64decode(_g)[0]):
    g = gzip.decompress(g)
g=list(g)
def gr(x,y):
    if(x>=0 and y>=0 and x<72 and y<16):
        return g[y*72 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<72 and y<16):
        g[y*72 + x]=v;
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
    gw(1,0,100)
    gw(0,0,0)
    return 1
def _1():
    global t0
    global t1
    t0=gr(1,0)-1
    t1=gr(1,0)-1
    gw(0,0,gr(1,0)+gr(0,0))

    return (17)if((t1)!=0)else(2)
def _2():
    gw(1,0,0)
    return 3
def _3():
    global t0
    t0=(1)if(99>gr(1,0))else(0)
    gw(gr(1,0)%10,(gr(1,0)/10)+6,(gr(1,0)+1)*(gr(1,0)+1))

    return (16)if((t0)!=0)else(4)
def _4():
    sa(gr(0,0))
    gw(1,0,gr(0,0))
    return 5
def _5():
    global t0
    t0=gr(1,0)-1
    gw(1,0,gr(1,0)-1)

    return (15)if((t0)!=0)else(6)
def _6():
    gw(1,0,99)
    sa(sp()+sp());
    return 7
def _7():
    sa(sr());
    sa(gr(gr(1,0)%10,(gr(1,0)/10)+6))

    return (8)if((gr(gr(1,0)%10,(gr(1,0)/10)+6))!=0)else(14)
def _8():
    v0=sp()
    sa((1)if(sp()>v0)else(0))


    return (13)if(sp()!=0)else(9)
def _9():
    sa(gr(1,0))
    gw(1,0,gr(1,0)-1)

    return (7)if(sp()!=0)else(10)
def _10():
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr());

    return (11)if(sp()!=0)else(12)
def _11():
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    return 6
def _12():
    sp();
    print(sp(),end=" ",flush=True)
    return 18
def _13():
    sa(sp()-gr(gr(1,0)%10,(gr(1,0)/10)+6))

    gw(gr(1,0)%10,(gr(1,0)/10)+6,0)
    return 9
def _14():
    sp();
    sp();
    return 9
def _15():
    sa(gr(0,0))
    return 5
def _16():
    gw(1,0,gr(1,0)+1)
    return 3
def _17():
    global t0
    gw(1,0,t0)
    return 1
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17]
c=0
while c<18:
    c=m[c]()
