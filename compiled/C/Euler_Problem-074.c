/* compiled with BefunCompile v1.0.7 (c) 2015 */
#include <stdio.h>
#include <stdlib.h>
#define int64 long long
char* _g = "v      X {#}  *{ }  ,// Project Euler - Problem 74{ } ,9CCC{ } ,qXXXX   |{-}  \\|{ } 9#{#}&}N{ }  *{#} ,O{ }  `{#} ,#{ } !#{#} +h"
           "{ } !5{#} +T{ } !K{#} +C{ } !W{#} +4{ } !i{#} +&{ } !t{#} *w{ } \"${#} *l{ } \",{#} *a{ } \":{#} *V{ } \"B{#} *O{ } \"I{#} *E{ } \"T{#"
           "} *<{ } \"\\{#} *3{ } \"g{#} **{ } \"m{#} *\"{ } \"w{#} )y{ } \"}{#} )r{ } #&{#} )j{ } #-{#} )d{ } #3{#} )]{ } #;{#} )W{ } #@{#} )P{ } "
           "#G{#} )J{ } #M{#} )C{ } #U{#} )={ } #Z{#} )6{ } #a{#} )1{ } #f{#} )+{ } #l{#} )%{ } #q{#} )!{ } #v{#} (z{ } #|{#} (u{ } $!{#} (p"
           "{ } $'{#} (j{ } $,{#} (e{ } $2{#} (`{ } $6{#} ([{ } $<{#} (W{ } $?{#} (S{ } $C{#} (N{ } $I{#} (I{ } $M{#} (D{ } $R{#} (A{ } $U{#"
           "} (<{ } $Z{#} (8{ } $^{#} (4{ } $c{#} (/{ } $f{#} (,{ } $k{#} ('{ } \"5{#}  E{ } \"5{#} (#{ } \"({#}  b{ } \"({#} ( { } !{{#}  ~{ } "
           "!{{#} '{{ } !v{#} !.{ } !u{#} 'w{ } !o{#} !@{ } !o{#} 's{ } !i{#} !M{ } !j{#} 'o{ } !e{#} ![{ } !e{#} 'l{ } !b{#} !d{ } !b{#} 'g"
           "{ } !^{#} !q{ } !^{#} 'd{ } ![{#} !y{ } ![{#} 'a{ } !W{#} \"&{ } !X{#} '\\{ } !V{#} \",{ } !V{#} 'Z{ } !T{#} \"3{ } !S{#} 'W{ } !Q{#"
           "} \"={ } !Q{#} 'S{ } !O{#} \"C{ } !O{#} 'P{ } !L{#} \"L{ } !M{#} 'L{ } !K{#} \"R{ } !K{#} 'I{ } !I{#} \"Z{ } !I{#} 'F{ } !G{#} \"`{ } "
           "!H{#} 'B{ } !E{#} \"h{ } !E{#} '@{ } !D{#} \"m{ } !D{#} '={ } !B{#} \"r{ } !C{#} ':{ } !A{#} \"y{ } !A{#} '7{ } !?{#} \"~{ } !@{#} '4"
           "{ } !>{#} #&{ } !>{#} '0{ } !={#} #+{ } !={#} '.{ } !;{#} #1{ } !<{#} '*{ } !;{#} #5{ } !;{#} '({ } !9{#} #<{ } !9{#} '${ } !9{#"
           "} #@{ } !8{#} '\"{ } !7{#} #F{ } !7{#} &}{ } !7{#} #J{ } !6{#} &{{ } !6{#} #M{ } !6{#} &y{ } !4{#} #S{ } !5{#} &v{ } !3{#} #W{ } "
           "!4{#} &s{ } !3{#} #\\{ } !3{#} &p{ } !2{#} #`{ } !2{#} &m{ } !1{#} #e{ } !1{#} &k{ } !0{#} #i{ } !0{#} &i{ } !/{#} #m{ } !0{#} &f"
           "{ } !.{#} #q{ } !/{#} &c{ } !.{#} #u{ } !.{#} &a{ } !-{#} #y{ } !-{#} &_{ } !-{#} #|{ } !,{#} &]{ } !+{#} $\"{ } !,{#} &Z{ } !*{#"
           "} $&{ } !+{#} &W{ } !+{#} $){ } !*{#} &U{ } !*{#} $-{ } !){#} &S{ } !){#} $0{ } !*{#} &P{ } !({#} $4{ } !){#} &M{ } !({#} $8{ } "
           "!({#} &K{ } !({#} $:{ } !({#} &J{ } !&{#} $>{ } !'{#} &G{ } !&{#} $B{ } !&{#} &E{ } !&{#} $D{ } !&{#} &C{ } !%{#} $H{ } !%{#} &A"
           "{ } !%{#} $J{ } !%{#} &>{ } !%{#} $O{ } !${#} &<{ } !#{#} $R{ } !${#} &:{ } !#{#} $U{ } !#{#} &8{ } !\"{#} $X{ } !\"{#} &6{ } !\"{#"
           "} $\\{ } !\"{#} &4{ } !\"{#} $]{ } !\"{#} &2{ } !\"{#} $_{ } !!{#} &1{ } !!{#} $c{ } !!{#} &.{ } !!{#} $e{ } !!{#} &+{ } !!{#} $i{ } "
           " ~{#} &+{ } ! {#} $k{ } ! {#} &'{ } ! {#} $n{ } ! {#} &&{ }  ~{#} $p{ } ! {#} &${ }  }{#} $t{ }  ~{#} &\"{ }  ~{#} $u{ }  }{#} &!"
           "{ }  }{#} $x{ }  }{#} %~{ }  }{#} ${{ }  |{#} %}{ }  |{#} $|{ }  }{#} %z{ }  |{#} %!{ }  |{#} %y{ }  |{#} %\"{ }  |{#} %v{ }  |{#"
           "} %&{ }  {{#} %u{ }  {{#} %'{ }  |{#} %s{ }  z{#} %+{ }  {{#} %q{ }  {{#} %,{ }  z{#} %p{ }  z{#} %/{ }  {{#} %m{ }  z{#} %1{ } "
           " z{#} %m{ }  z{#} %2{ }  z{#} %k{ }  y{#} %6{ }  x{#} %j{ }  y{#} %7{ }  y{#} %h{ }  y{#} %:{ }  x{#} %g{ }  x{#} %<{ }  x{#} %d"
           "{ }  x{#} %?{ }  x{#} %c{ }  x{#} %@{ }  x{#} %a{ }  x{#} %B{ }  w{#} %`{ }  x{#} %C{ }  x{#} %_{ }  w{#} %F{ }  w{#} %]{ }  w{#"
           "} %H{ }  w{#} %[{ }  w{#} %I{ }  w{#} %Z{ }  w{#} %L{ }  v{#} %Y{ }  v{#} %M{ }  w{#} %W{ }  v{#} %P{ }  u{#} %W{ }  u{#} %Q{ } "
           " v{#} %T{{ }  v{#} %S}  \"{ }  u{#} %U{ }  v{#} %Q{ }  u{#} %W{ }  u{#} %Q{ }  u{#} %X{ }  u{#} %O{ }  u{#} %Y{ }  u{#} %N{ }  u{"
           "#} %\\{ }  t{#} %M{ }  t{#} %]{ }  u{#} %K{ }  t{#} %_{ }  t{#} %J{ }  t{#} %a{ }  t{#} %I{ }  t{#} %b{ }  t{#} %G{ }  t{#} %c{ }"
           "  t{#} %G{ }  s{#} %f{ }  s{#} %E{ }  s{#} %g{ }  s{#} %D{ }  t{#} %h{ }  s{#} %C{ }  s{#} %i{ }  t{#} %A{ }  s{#} %k{ }  s{#} %"
           "A{ }  r{#} %m{ }  s{#} %@{ }  r{#} %n{ }  r{#} %>{ }  s{#} %o{ }  r{#} %>{ }  r{#} %q{ }  r{#} %={ }  q{#} %s{ }  r{#} %;{ }  r{"
           "#} %s{ }  r{#} %;{ }  q{#} %u{ }  r{{#} %9{ }  q{#} %w{ }  q}  \"{#} %8{ }  q{#} %y{ }  q{#} %7{ }  p{#} %{{ }  q{#} %5{ }  q{#} "
           "%|{ }  p{#} %4{ }  q{#} %}{ }  q{#} %3{ }  q{#} %~{ }  q{#} %2{ }  p{#} & { }  q{#} %1{ }  p{#} &\"{ }  p{#} %1{ }  p{#} &#{ }  p"
           "{#} %/{ }  p{#} &${ }  p{#} %/{ }  p{#} &%{ }  o{#} %.{ }  q{#} &%{ }  p{#} %-{ }  p{#} &&{ }  q{#} %,{ }  o{#} &({ }  p{#} %+{ "
           "}  p{#} &){ }  o{#} %+{ }  o{#} &*{ }  o{#} %+{ }  n{#} &,{ }  o{#} %){ }  o{#} &,{ }  o{#} %({ }  p{#} &-{ }  o{#} %'{ }  o{#} "
           "&.{ }  o{#} %'{ }  o{#} &/{ }  o{#} %&{ }  n{#} &0{ }  o{#} %%{ }  o{#} &0{ }  o{#} %${ }  o{#} &2{ }  n{#} %${ }  o{#} &3{ }  n"
           "{#} %#{ }  n{#} &4{ }  o{#} %\"{ }  n{#} &4{ }  o{{#} %!{ }  o{#} &5{ }  n}  \"{#} %!{ }  n{#} &6{ }  o{#} % { }  m{#} &8{ }  n{#}"
           " $~{ }  n{#} !Q{ {#} !Y}  \" {#} !P{ }  n{#} $~{ }  n{#} !O{     {#} !U}  \"     {#} !O{ }  m{#} $}{ }  n{#} !O{{ }  '{#} !S}  \"{ "
           "}  '{#} !N{ }  n{#} $|{ }  n{#} !M{{ }  +{#} !O}  \"{ }  +{#} !L{ }  n{#} $|{ }  n{#} !K{{ }  .{#} !L}  #{ }  m{#} $|{ }  n{#} !J"
           "{{ }  1{#} !I}  \"{ }  1{#} !J{ }  n{#} ${{ }  m{#} !I{{ }  4{#} !F}  \"{ }  4{#} !I{ }  n{#} $z{ }  n{#} !H{{ }  7{#} !C}  \"{ }  "
           "7{#} !G{ }  n{#} $z{ }  m{#} !G{{ }  :{#} !@}  \"{ }  :{#} !G{ }  m{#} $z{ }  m{#} !F{{ }  ={#} !=}  \"{ }  ={#} !F{ }  m{#} $y{ }"
           "  m{#} !D{{ }  @{#} !:}  \"{ }  @{#} !E{ }  m{#} $y{ }  m{#} !C{{ }  B{#} !8}  \"{ }  B{#} !D{ }  m{#} $x{ }  m{#} !B{{ }  F{#} !4"
           "}  \"{ }  F{#} !B{ }  m{#} $x{ }  m{#} !A{{ }  H{#} !2}  \"{ }  H{#} !A{ }  m{#} $x{ }  l{#} !@{{ }  L{#} !.}  \"{ }  L{#} !@{ }  l"
           "{#} $w{ }  m{#} !?{{ }  N{#} !,}  \"{ }  N{#} !?{ }  m{#} $v{ }  m{#} !={{ }  R{#} !(}  \"{ }  R{#} !>{ }  l{#} $v{ }  m{#} !<{{ }"
           "  U{#} !%}  \"{ }  U{#} !<{ }  l{#} $v{ }  m{#} !:{{ }  X{#} !\"}  \"{ }  X{#} !;{ }  m{#} $u{ }  l{#} !:{{ }  [{#}  ~}  \"{ }  [{#}"
           " !9{ }  m{#} $u{ }  l{#} !9{{ }  ]{#}  |}  \"{ }  ]{#} !8{ }  m{#} $t{ }  m{#} !7{{ }  a{#}  x}  \"{ }  a{#} !6{ }  m{#} $t{ }  m{"
           "#} !6{{ }  c{#}  v}  \"{ }  c{#} !6{ }  l{#} $t{ }  m{#} !4{{ }  g{#}  r}  \"{ }  g{#} !4{ }  l{#} $t{ }  m{#} !2{{ }  j{#}  o}  \""
           "{ }  j{#} !3{ }  l{#} $t{ }  l{#} !2{{ }  m{#}  l}  \"{ }  m{#} !1{ }  m{#} $s{ }  l{#} !0{{ }  p{#}  i}  \"{ }  p{#} !0{ }  m{#} "
           "$s{ }  l{#} !/{{ }  s{#}  f}  \"{ }  s{#} !.{ }  m{#} $s{ }  k{#} !.{{ }  v{#}  c}  \"{ }  v{#} !.{ }  l{#} $r{ }  l{#} !-{{ }  y{"
           "#}  `}  \"{ }  y{#} !,{ }  l{#} $r{ }  l{#} !+{{ }  |{#}  ]}  \"{ }  |{#} !+{ }  l{#} $r{ }  l{#} !*{{ }  ~{#}  [}  \"{ }  ~{#} !*{"
           " }  l{#} $r{ }  l{#} !({{ } !#{#}  W}  \"{ } !#{#} !){ }  k{#} $r{ }  l{#} !'{{ } !%{#}  U}  \"{ } !%{#} !({ }  k{#} $r{ }  l{#} !"
           "%{{ } !){#}  Q}  \"{ } !){#} !&{ }  k{#} $q{ }  m{#} !${{ } !+{#}  O}  \"{ } !+{#} !%{ }  k{#} $q{ }  m{#} !\"{{ } !/{#}  K}  \"{ } "
           "!/{#} !#{ }  l{#} $p{ }  m{#} !!{{ } !1{#}  I}  \"{ } !1{#} !\"{ }  l{#} $p{ }  l{#} ! {{ } !5{#}  E}  \"{ } !5{#} ! { }  l{#} $p{ "
           "}  l{#}  ~{{ } !8{#}  B}  \"{ } !8{#}  }{ }  l{#} $p{ }  l{#}  }{{ } !:{#}  @}  \"{ } !:{#}  |{ }  l{#} $p{ }  l{#}  {{{ } !>{#}  "
           "<}  \"{ } !>{#}  z{ }  l{#} $p{ }  l{#}  z{{ } !@{#}  :}  \"{ } !@{#}  y{ }  l{#} $p{ }  l{#}  x{{ } !D{#}  6}  \"{ } !D{#}  w{ }  "
           "l{#} $p{ }  l{#}  v{{ } !G{#}  3}  \"{ } !G{#}  v{ }  l{#} $p{ }  l{#}  u{{ } !J{#}  0}  \"{ } !J{#}  t{ }  l{#} $p{ }  l{#}  s{{ "
           "} !M{#}  -}  \"{ } !M{#}  s{ }  l{#} $p{ }  l{#}  r{{ } !P{#}  *}  \"{ } !P{#}  q{ }  l{#} $p{ }  l{#}  p{{ } !S{#}  '}  \"{ } !S{#"
           "}  p{ }  m{#} $o{ }  l{#}  o{{ } !V####}  \"{ } !V{#}  n{ }  m{#} $o{ }  l{#}  m{ }  l#{ } !Y#{ } \"F{#}  m{ }  m{#} $o{ }  l{#}  "
           "m{ }  l{###{ } !U##}  \"{ }  m{#}  l{ }  m{#} $o{ }  l{#}  m{ }  l####{ } !R{#}  ({ } !R####{ }  m{#}  l{ }  l{#} $p{ }  l{#}  m{"
           " }  l######{ } !O{#}  +{ } !O#####{ }  m{#}  l{ }  l{#} $p{ }  l{#}  m{ }  l{#}  '{ } !L{#}  .{ } !L{#}  '{ }  m{#}  l{ }  l{#} "
           "$p{ }  l{#}  m{ }  l{#}  ){ } !I{#}  1{ } !I{#}  ({ }  m{#}  l{ }  l{#} $p{ }  l{#}  m{ }  l{#}  +{ } !E{#}  5{ } !E{#}  *{ }  m"
           "{#}  l{ }  l{#} $p{ }  l{#}  m{ }  l{#}  ,{ } !C{#}  7{ } !C{#}  +{ }  m{#}  l{ }  l{#} $p{ }  l{#}  m{ }  l{#}  .{ } !?{#}  ;{ "
           "} !?{#}  -{ }  m{#}  l{ }  l{#} $p{ }  l{#}  m{ }  l{#}  .{ } !>{#}  <{ } !>{#}  .{ }  m{#}  l{ }  l{#} $p{ }  l{#}  m{ }  l{#} "
           " 1{ } !9{#}  A{ } !9{#}  0{ }  m{#}  l{ }  l{#} $p{ }  l{#}  m{ }  l{#}  2{ } !6{#}  D{ } !6{#}  2{ }  m{#}  l{ }  l{#} $p{ }  l"
           "{#}  m{ }  l{#}  3{ } !4{#}  F{ } !4{#}  3{ }  m{#}  l{ }  l{#} $p{ }  m{#}  l{ }  l{#}  5{ } !0{#}  J{ } !0{#}  5{ }  m{#}  l{ "
           "}  l{#} $p{ }  m{#}  l{ }  l{#}  6{ } !/{#}  K{ } !/{#}  5{ }  m{#}  l{ }  l{#} $q{ }  l{#}  l{ }  l{#}  7{ } !,{#}  N{ } !,{#} "
           " 7{ }  m{#}  l{ }  k{#} $r{ }  l{#}  l{ }  l{#}  9{ } !({#}  R{ } !({#}  9{ }  m{#}  l{ }  k{#} $r{ }  l{#}  l{ }  l{#}  ;{ } !$"
           "{#}  V{ } !${#}  ;{ }  m{#}  l{ }  k{#} $r{ }  l{#}  l{ }  l{#}  <{ } !\"{#}  X{ } !\"{#}  <{ }  m{#}  k{ }  l{#} $r{ }  l{#}  l{ "
           "}  l{#}  >{ }  }{#}  \\{ }  }{#}  >{ }  m{#}  k{ }  l{#} $r{ }  l{#}  l{ }  l{#}  ?{ }  {{#}  ^{ }  {{#}  ?{ }  m{#}  k{ }  l{#} "
           "$s{ }  k{#}  l{ }  l{#}  A{ }  x{#}  a{ }  x{#}  @{ }  m{#}  k{ }  l{#} $s{ }  l{#}  k{ }  l{#}  B{ }  u{#}  d{ }  u{#}  B{ }  m"
           "{#}  j{ }  m{#} $s{ }  l{#}  k{ }  l{#}  C{ }  s{#}  f{ }  s{#}  C{ }  m{#}  j{ }  m{#} $s{ }  l{#}  k{ }  l{#}  F{ }  n{#}  k{ "
           "}  n{#}  E{ }  m{#}  j{ }  m{#} $s{ }  l{#}  k{ }  l{#}  G{ }  l{#}  m{ }  l{#}  F{ }  m{#}  j{ }  m{#} $s{ }  m{#}  j{ }  l{#} "
           " I{ }  h{#}  q{ }  h{#}  H{ }  m{#}  j{ }  l{#} $t{ }  m{#}  j{ }  l{#}  J{ }  f{#}  s{ }  f{#}  I{ }  m{#}  j{ }  l{#} $t{ }  m"
           "{#}  j{ }  l{#}  K{ }  c{#}  v{ }  c{#}  K{ }  m{#}  j{ }  l{#} $u{ }  l{#}  j{ }  l{#}  M{ }  `{#}  y{ }  `{#}  L{ }  m{#}  i{ "
           "}  m{#} $u{ }  l{#}  j{ }  l{#}  N{ }  ]{#}  |{ }  ]{#}  N{ }  m{#}  i{ }  m{#} $u{ }  l{#}  j{ }  l{#}  P{ }  Y{#} !!{ }  Y{#} "
           " P{ }  m{#}  i{ }  m{#} $u{ }  m{#}  i{ }  l{#}  Q{ }  W{#} !#{ }  W{#}  Q{ }  m{#}  i{ }  m{#} $u{ }  m{#}  i{ }  l{#}  R{ }  U"
           "{#} !%{ }  U{#}  R{ }  m{#}  i{ }  l{#} $v{ }  m{#}  i{ }  l{#}  T{ }  Q{#} !){ }  Q{#}  T{ }  m{#}  h{ }  m{#} $v{ }  m{#}  i{ "
           "}  l{#}  V{ }  M{#} !-{ }  M{#}  V{ }  m{#}  h{ }  m{#} $w{ }  l{#}  i{ }  l{#}  W{ }  K{#} !/{ }  K{#}  W{ }  m{#}  h{ }  l{#} "
           "$x{ }  m{#}  h{ }  l{#}  X{ }  I{#} !1{ }  I{#}  X{ }  m{#}  g{ }  m{#} $x{ }  m{#}  h{ }  l{#}  Z{ }  F{#} !4{ }  F{#}  Y{ }  m"
           "{#}  g{ }  m{#} $y{ }  m{#}  g{ }  l{#}  \\{ }  A{#} !9{ }  A{#}  \\{ }  m{#}  g{ }  m{#} $y{ }  m{#}  g{ }  l{#}  ]{ }  ?{#} !;{ "
           "}  ?{#}  ]{ }  m{#}  g{ }  m{#} $y{ }  m{#}  g{ }  l{#}  _{ }  <{#} !>{ }  <{#}  ^{ }  m{#}  f{ }  m{#} $z{ }  m{#}  g{ }  l{#} "
           " `{ }  :{#} !@{ }  :{#}  _{ }  m{#}  f{ }  m{#} $z{ }  n{#}  f{ }  l{#}  b{ }  6{#} !D{ }  6{#}  a{ }  m{#}  e{ }  n{#} ${{ }  m"
           "{#}  f{ }  l{#}  d{ }  2{#} !H{ }  2{#}  c{ }  m{#}  e{ }  n{#} ${{ }  n{#}  e{ }  l{#}  e{ }  0{#} !J{ }  0{#}  d{ }  m{#}  e{ "
           "}  n{#} ${{ }  n{#}  e{ }  l{#}  g{ }  ,{#} !N{ }  ,{#}  f{ }  m{#}  d{ }  n{#} $|{ }  n{#}  e{ }  l{#}  g{ }  +{#} !O{ }  +{#} "
           " g{ }  m{#}  d{ }  n{#} $}{ }  n{#}  d{ }  l{#}  j      {#} !T      {#}  i{ }  m{#}  d{ }  m{#} $~{ }  n{#}  d{ }  l{#}  k    {#"
           "} !V    {#}  j{ }  m{#}  d{ }  m{#} % { }  m{#}  d{ }  l{#}  l {#} !Y {#}  l{ }  m{#}  c{ }  n{#} % { }  m{#}  d{ }  l{#} #5{ } "
           " l{#}  d{ }  n{#} % { }  n{#}  e{ }  k{#} #4{ }  j{#}  e{ }  o{#} % { }  o{#}  e{ }  l{#} #0{ }  k{#}  f{ }  n{#} %\"{ }  n{#}  g"
           "{ }  k{#} #.{ }  j{#}  h{ }  n{#} %\"{ }  n{#}  i{ }  k{#} #*{ }  j{#}  i{ }  o{#} %\"{ }  o{#}  i{ }  k{#} #'{ }  l{#}  i{ }  n{#"
           "} %#{ }  o{#}  k{ }  k{#} #${ }  j{#}  k{ }  o{#} %${ }  n{#}  l{ }  k{#} #!{ }  k{#}  l{ }  n{#} %%{ }  o{#}  m{ }  k{#} \"}{ } "
           " j{#}  m{ }  o{#} %&{ }  o{#}  m{ }  k{#} \"z{ }  l{#}  m{ }  o{#} %&{ }  o{#}  o{ }  k{#} \"w{ }  j{#}  o{ }  o{#} %'{ }  o{#}  p"
           "{ }  k{#} \"t{ }  k{#}  p{ }  o{#} %({ }  o{#}  q{ }  j{#} \"r{ }  k{#}  q{ }  n{#} %*{ }  n{#}  r{ }  k{#} \"n{ }  k{#}  r{ }  o{#"
           "} %*{ }  o{#}  s{ }  j{#} \"l{ }  k{#}  r{ }  p{#} %*{ }  p{#}  t{ }  j{#} \"h{ }  k{#}  t{ }  o{#} %+{ }  p{#}  u{ }  j{#} \"f{ } "
           " k{#}  u{ }  o{#} %,{ }  o{#}  w{ }  j{#} \"b{ }  k{#}  v{ }  p{#} %,{ }  p{#}  v{ }  l{#} \"_{ }  k{#}  v{ }  p{#} %.{ }  p{#}  x"
           "{ }  j{#} \"\\{ }  k{#}  x{ }  o{#} %/{ }  p{#}  y{ }  k{#} \"Y{ }  j{#}  y{ }  p{#} %0{ }  p{#}  y{ }  k{#} \"W{ }  j{#}  z{ }  p{#"
           "} %0{ }  p{#}  z{ }  l{#} \"S{ }  k{#}  z{ }  p{#} %1{ }  q{#}  {{ }  k{#} \"Q{ }  j{#}  {{ }  q{#} %2{ }  q{#}  |{ }  k{#} \"M{ } "
           " j{#}  }{ }  q{#} %2{ }  q{#}  }{ }  k{#} \"J{ }  k{#}  }{ }  q{#} %4{ }  q{#}  }{ }  l{#} \"G{ }  k{#}  ~{ }  p{#} %5{ }  q{#} ! "
           "{ }  k{#} \"D{ }  k{#} ! { }  q{#} %6{ }  q{#} !!{ }  k{#} \"A{ }  j{#} !!{ }  r{#} %6{ }  r{#} !!{ }  k{#} \">{ }  k{#} !\"{ }  q{#"
           "} %8{ }  q{#} !#{ }  k{#} \";{ }  k{#} !\"{ }  q{#} %:{ }  q{#} !#{ }  k{#} \"8{ }  k{#} !#{ }  r{#} %:{ }  r{#} !${ }  j{#} \"6{ } "
           " k{#} !${ }  r{#} %:{ }  r{#} !%{ }  k{#} \"2{ }  k{#} !%{ }  r{#} %<{ }  r{#} !&{ }  j{#} \"0{ }  k{#} !&{ }  r{#} %<{ }  r{#} !("
           "{ }  j{#} \",{ }  k{#} !'{ }  r{#} %>{ }  r{#} !({ }  j{#} \"*{ }  k{#} !'{ }  r{#} %@{ }  r{#} !({ }  k{#} \"&{ }  k{#} !({ }  s{#"
           "} %@{ }  s{#} !){ }  j{#} \"${ }  k{#} !){ }  r{#} %B{ }  r{#} !+{ }  j{#} \" { }  k{#} !*{ }  s{#} %B{ }  s{#} !+{ }  k{#} !|{ } "
           " j{#} !+{ }  s{#} %C{ }  t{#} !+{ }  k{#} !z{ }  j{#} !,{ }  s{#} %E{ }  s{#} !,{ }  k{#} !v{ }  j{#} !-{ }  s{#} %F{ }  s{#} !-"
           "{ }  k{#} !t{ }  k{#} !,{ }  t{#} %G{ }  s{#} !-{ }  l{#} !p{ }  k{#} !-{ }  t{#} %H{ }  t{#} !.{ }  k{#} !m{ }  k{#} !/{ }  t{#"
           "} %I{ }  t{#} !/{ }  k{#} !j{ }  j{#} !/{ }  t{#} %K{ }  u{#} !/{ }  k{#} !g{ }  l{#} !/{ }  t{#} %L{ }  u{#} !0{ }  k{#} !d{ } "
           " j{#} !1{ }  t{#} %N{ }  t{#} !1{ }  k{#} !a{ }  k{#} !1{ }  t{#} %P{ }  u{#} !1{ }  k{#} !^{ }  j{#} !2{ }  u{#} %P{ }  u{#} !2"
           "{ }  k{#} ![{ }  l{#} !1{ }  u{#} %R{ }  u{#} !3{ }  j{#} !Y{ }  k{#} !3{ }  u{#} %R{ }  v{#} !3{ }  k{#} !U{ }  k{#} !3{ }  v{#"
           "} %T{ }  v{#} !4{ }  j{#} !S{ }  k{#} !4{ }  u{#} %V{ }  v{#} !5{ }  j{#} !O{ }  k{#} !5{ }  v{#} %V{ }  v{#} !6{ }  j{#} !M{ } "
           " k{#} !5{ }  v{#} %X{ }  w{#} !6{ }  j{#} !I{ }  k{#} !6{ }  v{#} %Y{ }  w{#} !6{ }  k{#} !G{ }  k{#} !6{ }  w{#} %[{ }  w{#} !7"
           "{ }  j{#} !C{ }  k{#} !7{ }  w{#} %\\{ }  w{#} !8{ }  k{#} !@{ }  k{#} !7{ }  w{#} %^{ }  w{#} !9{ }  j{#} !={ }  k{#} !8{ }  x{#"
           "} %^{ }  x{#} !8{ }  l{#} !:{ }  k{#} !8{ }  x{#} %`{ }  x{#} !9{ }  k{#} !8{ }  j{#} !9{ }  x{#} %b{ }  x{#} !9{ }  l{#} !4{ } "
           " k{#} !9{ }  x{#} %d{ }  x{#} !:{ }  k{#} !1{ }  k{#} !:{ }  x{#} %f{ }  x{#} !:{ }  l{#} !.{ }  k{#} !:{ }  x{#} %h{ }  x{#} !;"
           "{ }  k{#} !+{ }  k{#} !;{ }  y{#} %h{ }  z{#} !;{ }  k{#} !({ }  j{#} !<{ }  y{#} %j{ }  y{#} !<{ }  k{#} !%{ }  k{#} !<{ }  y{#"
           "} %l{ }  z{#} !<{ }  k{#} !\"{ }  j{#} !={ }  y{#} %n{ }  z{#} !<{ }  k{#}  ~{ }  l{#} !<{ }  z{#} %n{ }  z{#} !>{ }  j{#}  |{ } "
           " k{#} !={ }  z{#} %q{ }  z{#} !={ }  k{#}  x{ }  l{#} !<{ }  {{#} %r{ }  {{#} !>{ }  j{#}  v{ }  k{#} !>{ }  z{#} %t{ }  |{#} !>"
           "{ }  j{#}  r{ }  k{#} !>{ }  {{#} %v{ }  {{#} !?{ }  j{#}  p{ }  k{#} !>{ }  {{#} %x{ }  |{#} !>{ }  k{#}  l{ }  k{#} !>{ }  }{#"
           "} %y{ }  |{#} !?{ }  j{#}  j{ }  k{#} !?{ }  {{#} %|{ }  }{#} !?{ }  j{#}  f{ }  k{#} !?{ }  }{#} %}{ }  |{#} !?{ }  l{#}  c{ } "
           " k{#} !?{ }  }{#} %~{ }  ~{#} !@{ }  j{#}  `{ }  k{#} !?{ }  ~{#} &\"{ }  }{#} !@{ }  k{#}  ]{ }  j{#} !@{ }  ~{#} &#{ }  ~{#} !@"
           "{ }  k{#}  [{ }  j{#} !A{ }  }{#} &%{ } ! {#} !@{ }  k{#}  W{ }  j{#} !A{ }  ~{#} &'{ } ! {#} !@{ }  k{#}  U{ }  j{#} !@{ } ! {#"
           "} &){ } !!{#} !?{ }  l{#}  Q{ }  k{#} !@{ } ! {#} &+{ } !!{#} !@{ }  k{#}  N{ }  k{#} !@{ } !!{#} &-{ } !\"{#} !?{ }  l{#}  K{ } "
           " k{#} !@{ } !!{#} &/{ } !\"{#} !@{ }  k{#}  H{ }  k{#} !@{ } !#{#} &0{ } !#{#} !@{ }  k{#}  E{ }  j{#} !@{ } !#{#} &3{ } !${#} !?"
           "{ }  k{#}  B{ }  k{#} !@{ } !#{#} &5{ } !${#} !@{ }  j{#}  @{ }  k{#} !?{ } !%{#} &6{ } !%{#} !?{ }  k{#}  <{ }  l{#} !>{ } !%{#"
           "} &9{ } !&{#} !?{ }  j{#}  :{ }  k{#} !?{ } !%{#} &;{ } !&{#} !@{ }  j{#}  6{ }  k{#} !?{ } !&{#} &={ } !'{#} !>{ }  k{#}  4{ } "
           " k{#} !?{ } !&{#} &?{ } !({#} !?{ }  j{#}  0{ }  k{#} !>{ } !({#} &B{ } !'{#} !?{ }  j{#}  .{ }  k{#} !>{ } !({#} &D{ } !){#} !>"
           "{ }  j{#}  *{ }  k{#} !>{ } !){#} &E{ } !*{#} !>{ }  k{#}  '{ }  k{#} !={ } !*{#} &H{ } !*{#} !={ }  k####{ }  k{#} !>{ } !){#} "
           "&K{ } !*{#} !={ } !Z{#} !<{ } !+{#} &L{ } !+{#} !;{ } !Z{#} !:{ } !+{#} &O{ } !,{#} !9{ } !Z{#} !9{ } !+{#} &Q{ } !,{#} !8{ } !Z"
           "{#} !7{ } !,{#} &T{ } !,{#} !6{ } !Z{#} !6{ } !,{#} &U{ } !-{#} !5{ } !Z{#} !4{ } !-{#} &X{ } !-{#} !3{ } !Z{#} !3{ } !,{#} &[{ "
           "} !-{#} !2{ } !Z{#} !1{ } !-{#} &^{ } !-{#} !0{ } !Z{#} !/{ } !.{#} &`{ } !-{#} !/{ } !Z{#} !.{ } !.{#} &b{ } !-{#} !.{ } !Z{#} "
           "!,{ } !.{#} &e{ } !.{#} !,{ } !Z{#} !,{ } !-{#} &g{ } !.{#} !+{ } !Z{#} !+{ } !.{#} &i{ } !-{#} !*{ } !Z{#} !){ } !.{#} &l{ } !-"
           "{#} !){ } !Z{#} !({ } !-{#} &o{ } !-{#} !({ } !Z{#} !'{ } !-{#} &q{ } !.{#} !&{ } !Z{#} !&{ } !-{#} &t{ } !-{#} !%{ } !Z{#} !${ "
           "} !-{#} &w{ } !-{#} !${ } !Z{#} !${ } !,{#} &z{ } !,{#} !#{ } !Z{#} !#{ } !+{#} &}{ } !,{#} !\"{ } !Z{#} !!{ } !,{#} ' { } !,{#} "
           "!!{ } !Z{#} !!{ } !+{#} '#{ } !+{#} ! { } !Z{#} ! { } !*{#} '&{ } !*{#} ! { } !Z{#}  ~{ } !*{#} '){ } !*{#}  }{ } !Z{#}  }{ } !)"
           "{#} ',{ } !){#}  }{ } !Z{#}  |{ } !){#} '/{ } !({#}  |{ } !Z{#}  {{ } !({#} '2{ } !({#}  {{ } !Z{#}  {{ } !'{#} '5{ } !'{#}  z{ "
           "} !Z{#}  z{ } !&{#} '8{ } !&{#}  z{ } !Z{#}  y{ } !&{#} ';{ } !%{#}  y{ } !Z{#}  x{ } !%{#} '>{ } !%{#}  x{ } !Z{#}  x{ } !${#} "
           "'A{ } !#{#}  x{ } !Z{#}  w{ } !${#} 'C{ } !#{#}  w{ } !Z{#}  w{ } !\"{#} 'G{ } !!{#}  w{ } !Z{#}  w{ } !!{#} 'J{ }  ~{#}  w{ } !Z"
           "{#}  v{ }  ~{#} 'N{ }  ~{#}  v{ } !Z{#}  u{ }  ~{#} 'Q{ }  }{#}  u{ } !Z{#}  u{ }  |{#} 'T{ }  |{#}  u{ } !Z{#}  t{ }  |{#} 'X{ "
           "}  z{#}  t{ } !Z{#}  t{ }  z{#} '[{ }  y{#}  t{ } !Z{#}  t{ }  x{#} '_{ }  w{#}  t{ } !Z{#}  s{ }  w{#} 'c{ }  v{#}  s{ } !Z{#} "
           " r{ }  w{#} 'e{ }  u{#}  s{ } !Z{#}  r{ }  u{#} 'i{ }  t{#}  r{ } !Z{#}  r{ }  s{#} 'm{ }  r{#}  r{ } !Z{#}  r{ }  q{#} 'q{ }  p"
           "{#}  r{ } !Z{#}  q{ }  p{#} 'u{ }  n{#}  r{ } !Z{#}  q{ }  n{#} 'y{ }  m{#}  q{ } !Z{#}  p{ }  m{#} '}{ }  k{#}  q{ } !Z{#}  p{ "
           "}  l{#} (!{ }  j{{#}  p{ } !Z{#}  p{ }  i{#} (%{ }  i}  \"{{#}  p{ } !Z{#}  o{ }  j{#} (%{ }  i}  \"{#}  p{{ } !Z{#}  o{ }  j{#} ("
           "%{ }  j{#}  o}  ${{ } !Z{#}  n{ }  k{#} (%{ }  j{#}  o}  #{ } !Z{#}  n{ }  k{{#} (%{ }  k{#}  n{ } !Z{#}  m{ }  l}  %{{#} (%{ } "
           " l{#}  m{ } !Z{#}  m{ }  l}  +{{#} (%{ }  l{#}  m{ } !Z{#}  l{ }  m}  8{{#} (%{ } $o}  S{{#} (%{ }  l{#} #5{ }  m}  >{{#} (%{ } "
           " m{#} #4{ }  m}  \"{#} (%{ }  m{#} #3{ }  n{#} (%{ }  m{#} #2{ }  o{#} (%{ }  n{#} #1{ }  o{#} (%{ }  o{#} #0{ }  o{#} (%{ }  o{#"
           "} #/{ }  p{#} (%{ }  p{#} #-{ }  q{#} (%{ }  q{#} #+{ }  r{#} (%{ }  r{#} #){ }  s{#} (%{ }  s{#} #'{ }  t{#} (%{ }  t{#} #&{ } "
           " t{#} (%{ }  u{#} ##{ }  v{#} (%{ }  v{#} #!{ }  w{#} (%{ }  x{#} \"}{ }  x{#} (%{ }  z{#} \"y{ }  z{#} (%{ }  |{#} \"t{ }  }{#} (%"
           "{ }  ~{#} \"p{ } ! {#} (%{ } !\"{#} \"j{ } !#{#} (%{ } !${#} \"f{ } !%{#} (%{ } !*{#} \"Z{ } !+{{#} (%{ } $o}  \"{#} (%{{ } $n{#} (&} "
           " ${ } $n{#} ('{{ } $l{#} ((}  \"{ } $l{#} (){ } $k{#} (){ } $j{#} (*{ } $j{{#} (+{ } $i}  \"{#} (+{ } $h{#} (-{ } $f{#} (/{ } $e{#"
           "} (/{ } $d{#} (1{ } $c{#} (1{ } $b{#} (3{ } $`{#} (5{ } $_{#} (5{ } $^{#} (7{ } $\\{#} (9{ } $Z{#} (;{ } $X{#} (={ } $V{#} (?{ } "
           "$T{#} (A{ } $S{#} (B{ } $P{#} (E{ } $N{#} (G{ } $L{#} (J{ } $I{#} (L{ } $F{#} (P{ } $C{#} (R{ } $@{#} (V{ } $={#} (X{ } $:{#} (\\"
           "{ } $6{#} (`{ } $3{#} (c{ } $/{#} (g{ } $*{#} (l{ } $'{#} (p{ } $!{#} (u{ } #{{#} (|{ } #s{#} )#{ } #o{#} )+{ } #c{#} )5{ } #[{#"
           "} )B{ } #I{#} )U{ } #5{#} )_{ } #5{{#} )`{ } #4}  %{#} )`{{ } #3{#} )a}  \"{ } #3{#} )b{ } #1{{#} )d{ } #0}  \"{#} )d{ } #/{#} )e{"
           " } #/{#} )f{ } #.{#} )f{ } #-{#} )h{ } #+{#} )j{ } #*{#} )j{ } #){#} )l{ } #'{#} )n{ } #&{#} )n{ } #%{#} )p{ } #${#} )q{ } #!{#}"
           " )t{ } # {#} )u{ } \"}{#} )v{ } \"|{#} )y{ } \"y{#} )z{ } \"x{#} )|{ } \"v{#} * { } \"s{#} *\"{ } \"p{#} *%{ } \"n{#} *'{ } \"l{#} **{ } \""
           "h{#} *-{ } \"f{#} *0{ } \"b{#} *4{ } \"_{#} *7{ } \"Z{#} *;{ } \"X{#} *>{ } \"T{#} *B{ } \"P{#} *F{ } \"L{#} *K{ } \"F{#} *Q{ } \"A{#} *V{"
           " } \":{#} *]{ } \"4{#} *e{ } \"*{#} *o{ } \"!{#} *|{ } !m{#}'*Q{ } ,t>98+8*9*11p\"+&\"*2/21p\";};}@\"**31p042p31g>1-:0\\:11g%v{ } ,Bvg11:"
           "-8*:+\"W~\"2p+4/g11\\%g11:/3*\"'C\"2p<|:p+4/g11\\ <{ }  'v   <{ } ,6%>8-:11g%\\11g/4+p3\",!\"*2+:11g%\\11g/4+^$      >:70g:1+70p9 +0v{ } ,"
           "7\\^**\"CCQ\"3p+4/g11\\%g11:+\"+~\"3p+4/g11\\<>070p11|-+55g07*g07  p<^{ }  *p22+g22_v{ } ,#>11g/4+p2\"m\"8*:11g%\\11g/4+ v{ }  )^%g11:00<{"
           " }  +# >:55+%9+0v>11g/4+g: ^${ } ,#v1$p+4/g11\\%g11:-7*:+\"W~\"2p<>12g22g1+:22p9+2p32g1+32p12g0\\:|:/+55\\g <^\\%g11:g21<{ } ,$>:12p02"
           "2p092p032p32g9+2g12g-|-g21g2+9g23{ }  2<>$>\\# :#+_+:12p31g`!|{ } ,%v{ }  :<{ }  <<^{ }  4<<{ } ,#+>22g\"<\"-#v_42g1+42p>1>:9+2g31g"
           "`#v_::22g1+\\-\\9+2v{ } ,C1 >$42g.@ >{ }  )^ ^+1_v#-g23:<p+4/g11\\%g11:g<{ } ,C^_^#-g13:{ }  0$<{ } ,Y";
int t=0;int z=0;
int64 g[1019592];
int d(){int s,w,i,j,h;h=z;for(;t<19939;t++)if(_g[t]==';')g[z++]=_g[++t];else if(_g[t]=='}')return z-h;else if(_g[t]=='{'){t++;s=z;w=d();for(i=1;i<_g[t+1]*9025+_g[t+2]*95+_g[t+3]-291872;i++)for(j=0;j<w;g[z++]=g[s+j++]);t+=3;}else g[z++]=_g[t];return z-h;}
int64 gr(int64 x,int64 y){if(x>=0&&y>=0&&x<1224&&y<833){return g[y*1224+x];}else{return 0;}}
void gw(int64 x,int64 y,int64 v){if(x>=0&&y>=0&&x<1224&&y<833){g[y*1224+x]=v;}}
int64 td(int64 a,int64 b){ return (b==0)?0:(a/b); }
int64 tm(int64 a,int64 b){ return (b==0)?0:(a%b); }
int64*s;int q=16384;int y=0;
int64 sp(){if(!y)return 0;return s[--y];}
void sa(int64 v){if(q-y<8)s=(int64*)realloc(s,(q*=2)*sizeof(int64));s[y++]=v;}
int64 sr(){if(!y)return 0;return s[y-1];}
int main(void)
{
    int64 t0;
    d();
    s=(int64*)calloc(q,sizeof(int64));
    gw(1,1,1224);
    gw(2,1,817);
    gw(3,1,1000000);
    gw(4,2,0);
    sa(gr(3,1)-1);
    gw(tm(gr(3,1)-1,gr(1,1)),(td(gr(3,1)-1,gr(1,1)))+4,0);
_1:
    sa(sr());
    if(sp()!=0)goto _26;else goto _2;
_2:
    gw(7,0,0);
    sp();
    sa(1);
_3:
    sa(sr());
    sa(gr(7,0));
    gw(7,0,gr(7,0)+1);
    sa(sp()+9LL);
    sa(0);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sp()*gr(7,0));
    if(gr(7,0)!=10)goto _3;else goto _5;
_5:
    gw(0,4,0);
    gw(tm(169,gr(1,1)),(td(169,gr(1,1)))+4,3);
    gw(tm(363601,gr(1,1)),(td(363601,gr(1,1)))+4,3);
    gw(tm(1454,gr(1,1)),(td(1454,gr(1,1)))+4,3);
    gw(tm(871,gr(1,1)),(td(871,gr(1,1)))+4,2);
    gw(tm(45361,gr(1,1)),(td(45361,gr(1,1)))+4,2);
    gw(tm(872,gr(1,1)),(td(872,gr(1,1)))+4,2);
    gw(tm(45362,gr(1,1)),(td(45362,gr(1,1)))+4,2);
    gw(1,2,1);
    gw(2,2,0);
    gw(9,2,0);
    gw(3,2,0);
    sp();
    sa(1);
_6:
    if(gr(gr(3,2)+9,2)!=gr(1,2))goto _7;else goto _13;
_7:
    sa(gr(1,2));
    sa(gr(2,2)+1);
    gw(2,2,gr(2,2)+1);
    sa(sp()+9LL);
    sa(2);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    gw(3,2,gr(3,2)+1);
    sa(0);
    sa(gr(1,2));
    if((gr(1,2))!=0)goto _24;else goto _8;
_8:
    sp();
_9:
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sr());
    if(sp()!=0)goto _23;else goto _10;
_10:
    sa(sp()+sp());
    sa(sr());
    gw(1,2,sp());
    sa((sp()>gr(3,1))?1:0);
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _11;else goto _6;
_11:
    t0=gr(tm(gr(1,2),gr(1,1)),(td(gr(1,2),gr(1,1)))+4);
    if((gr(tm(gr(1,2),gr(1,1)),(td(gr(1,2),gr(1,1)))+4))!=0)goto _12;else goto _6;
_12:
    t0=t0+gr(2,2);
    gw(2,2,t0);
_13:
    if(gr(2,2)!=60)goto _14;else goto _22;
_14:
    sa(1);
    sa(gr(10,2)>gr(3,1)?1:0);
_15:
    if(sp()!=0)goto _17;else goto _16;
_16:
    sa(sr());
    sa(sr());
    t0=gr(2,2)+1;
    sa(t0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa(sp()-v0);}
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+9LL);
    sa(2);
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(tm(sr(),gr(1,1)));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1,1)));
    sa(sp()+4LL);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
_17:
    if(sr()!=gr(3,2))goto _21;else goto _18;
_18:
    sp();
    if(sr()!=gr(3,1))goto _20;else goto _19;
_19:
    printf("%lld", gr(4,2));
    sp();
    return 0;
_20:
    sa(sp()+1LL);
    sa(sr());
    gw(1,2,sp());
    gw(2,2,0);
    gw(9,2,0);
    gw(3,2,0);
    goto _6;
_21:
    sa(sp()+1LL);
    sa(sr()+9);
    sa(2);
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa((sp()>gr(3,1))?1:0);
    goto _15;
_22:
    gw(4,2,gr(4,2)+1);
    goto _14;
_23:
    sa(sp()+sp());
    goto _9;
_24:
    sa((tm(sr(),10))+9);
    sa(0);
    {int64 v0=sp();sa(gr(sp(),v0));}
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),10));
    sa(sr());
    if(sp()!=0)goto _24;else goto _8;
_26:
    sa(sp()-1LL);
    sa(sr());
    sa(0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(tm(sr(),gr(1,1)));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1,1)));
    sa(sp()+4LL);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    goto _1;
}