#!/usr/bin/env python3

# transpiled with BefunCompile v1.3.0 (c) 2017
import gzip, base64
_g = ("AR+LCAAAAAAABACtk7FygzAMQH/FQLpEcU8WEDBHff2MDrkkm1dPnvj4ynYAtyVtL60GnZAt6UkW/m0W8bD4f8jxH2I0kkNFTpsBT8r5P2WbTlINYnyEQ5FtWziIaidK"
  + "8VIeDuJZvP4y2DtCLjpdtSUMjgcIxo0os8NlHkbcH41BJIu2xFIqJ7xZvgZ9nfh4IHLcnJyEIbLKxqDKX0S6qMtrUZ0vS7qq+lTLKDivtSapHRGowRKNoXWpuG2HrICL"
  + "stexg9Toiyv78DetZ8IJISQcA8d3YkTO7y8bV5gafiyfZcznWL6V4ctxDsVHXIBP3UYU1rzBvL0xrg5r5HmbnPlIYlMBsloWrPuoO1kALLPmwZ54rI5q2MO4AU5Bba7B"
  + "MkKzY4LhOawyb/T5602cOY6yS8h8d98nE4Ktb3av4QkKbwB4OT5MOqb1BR+3Pcjw5tjvQ2yyu2An8yjb8JTgeZpOJV/YibESM0cj25XjmHHc8KDpIgfEtXasFKSHSN1F"
  + "jg5vtY8ZR7tyNLKOHHcfnizJeuVoMo4bHmCbOO7kiBz1zNFkHPXKQfFf+ZaDf6eVgzKOeuagwGE23pblHVzPp+QcBgAA")
g = base64.b64decode(_g)[1:]
for i in range(base64.b64decode(_g)[0]):
    g = gzip.decompress(g)
g=list(g)
def gr(x,y):
    if(x>=0 and y>=0 and x<68 and y<23):
        return g[y*68 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<68 and y<23):
        g[y*68 + x]=v;
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
    gw(0,2,9)
    gw(1,2,0)
    gw(9,1,0)
    sa(8)
    sa(9)
    return 1
def _1():
    return (26)if(sp()!=0)else(2)
def _2():
    sp();
    return 3
def _3():
    return (25)if(gr(0,2)>9)else(4)
def _4():
    sa(gr(gr(0,2),0)-48)

    return (5)if((gr(gr(0,2),0)-48)>9)else(24)
def _5():
    gw(2,2,0)
    sp();
    sa(-10)
    return 6
def _6():
    return (19)if(sp()!=0)else(7)
def _7():
    return (8)if(gr(gr(0,2),0)>57)else(18)
def _8():
    gw(0,2,gr(0,2)+1)
    return 9
def _9():
    return (10)if(0>gr(0,2))else(14)
def _10():
    gw(0,2,0)
    gw(3,2,0)
    gw(3,2,(gr(0,0)-48)+(gr(3,2)*10))
    sa(1)
    sa(-9)
    return 11
def _11():
    return (12)if(sp()!=0)else(13)
def _12():
    global t0
    sa(sr());
    sa(0)
    v0=sp()
    t0=gr(sp(),v0)
    t0=t0-48
    t0=t0+(gr(3,2)*10)
    gw(3,2,t0)
    sa(sr()+1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()-9)
    return 11
def _13():
    print(gr(3,2),end=" ",flush=True)
    print(chr(10),end="",flush=True)
    gw(1,2,gr(3,2)+gr(1,2))
    sp();
    return 3
def _14():
    return (3)if((((0)if(gr(0,2)-9!=0)else(1))+((0)if(gr(0,2)-8!=0)else(1))+((0)if(gr(0,2)-7!=0)else(1))+((0)if((gr(0,2)-6)+((((((gr(7,0)-48)*10)+(gr(8,0)-48))*10)+(gr(9,0)-48))%17)!=0)else(1))+((0)if((gr(0,2)-5)+((((((gr(6,0)-48)*10)+(gr(7,0)-48))*10)+(gr(8,0)-48))%13)!=0)else(1))+((0)if((gr(0,2)-4)+((((((gr(5,0)-48)*10)+(gr(6,0)-48))*10)+(gr(7,0)-48))%11)!=0)else(1))+((0)if((gr(0,2)-3)+((((((gr(4,0)-48)*10)+(gr(5,0)-48))*10)+(gr(6,0)-48))%7)!=0)else(1))+((0)if((gr(0,2)-2)+((((((gr(3,0)-48)*10)+(gr(4,0)-48))*10)+(gr(5,0)-48))%5)!=0)else(1))+((0)if((gr(0,2)-1)+((((((gr(2,0)-48)*10)+(gr(3,0)-48))*10)+(gr(4,0)-48))%3)!=0)else(1))+((0)if(gr(0,2)+((((((gr(1,0)-48)*10)+(gr(2,0)-48))*10)+(gr(3,0)-48))%2)!=0)else(1)))!=0)else(15)
def _15():
    return (16)if(gr(gr(0,2),0)>57)else(17)
def _16():
    gw(0,2,gr(0,2)+1)
    return 3
def _17():
    gw(gr(gr(0,2),0)-48,1,0)
    gw(gr(0,2),0,88)
    gw(0,2,gr(0,2)+1)
    return 3
def _18():
    gw(gr(gr(0,2),0)-48,1,0)
    gw(gr(0,2),0,88)
    return 8
def _19():
    return (20)if((gr(gr(2,2),1))!=0)else(21)
def _20():
    global t0
    t0=gr(2,2)-9
    gw(2,2,gr(2,2)+1)

    return (19)if((t0)!=0)else(7)
def _21():
    return (22)if(gr(gr(0,2),0)>57)else(23)
def _22():
    gw(gr(2,2),1,1)
    gw(gr(0,2),0,gr(2,2)+48)
    gw(0,2,gr(0,2)-1)
    return 9
def _23():
    gw(gr(gr(0,2),0)-48,1,0)
    return 22
def _24():
    sa(sp()+1)

    sa(sr());
    gw(2,2,sp())
    sa(sp()-10)
    return 6
def _25():
    print(chr(10),end="",flush=True)
    print("= ",end="",flush=True)
    print(gr(1,2),end=" ",flush=True)
    return 27
def _26():
    sa(sr());
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(1)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr()-1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    return 1
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17,_18,_19,_20,_21,_22,_23,_24,_25,_26]
c=0
while c<27:
    c=m[c]()