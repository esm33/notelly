/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_
// Simple Drawing Tool
// © 2019 Kazuya Hiruma
// Version 1.0.0
/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_

========================================================================================
## 更新履歴

Version 1.0.0:
- First release.
========================================================================================


Simple Drawing ToolはuGUIを使ったフリーハンドによるドローイング機能を提供します。


## はじめに

SimpleDrawingTool prefabにはなにができるかのサンプルが含まれています。
まずはこれをシーンに配置することで「なにができるか」を把握することができるでしょう。


## スクリプトからの利用方法

本アセットはスクリプトから操作することが可能です。
主な機能は以下の通りです。

1. ブラシの変更
2. カラーの変更
3. ブラシサイズの変更
4. キャンバスのクリア
5. アンドゥ機能
6. 描いた内容のPNG保存


### コントロールするためのインターフェース

上記機能は、スクリプトから操作することが可能です。
用意されているインターフェースは以下の通りです。


#### シンタックス

- void SimpleDrawingTool.SetBrush(Texture2D brush);

ドローイングのブラシを変更します。


- void SimpleDrawingTool.SetBrushSize(float size);

ドローイングのブラシサイズを変更します。


- void SimpleDrawingTool.SetColor(Color color);

ドローイングの色を変更します。


- void SimpleDrawingTool.Undo();

アンドゥ機能です。ひとつ前の書き込みを削除します。


- void SimpleDrawingTool.Clear();

キャンバスをすべてクリアします。


もし使い方など、詳しい内容を知りたい方は、"DrawController" クラスが、ツールをどう使うかのサンプルになっているので御覧ください。