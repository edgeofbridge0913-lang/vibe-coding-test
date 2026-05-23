import tkinter as tk
from tkinter import ttk

class DinosaurGuideApp(tk.Tk):
    def __init__(self):
        super().__init__()
        self.title("恐竜図鑑アプリ")
        self.geometry("520x320")
        self.resizable(False, False)

        self._create_widgets()

    def _create_widgets(self):
        main_frame = ttk.Frame(self, padding=16)
        main_frame.pack(fill=tk.BOTH, expand=True)

        left_frame = ttk.Frame(main_frame)
        left_frame.pack(side=tk.LEFT, fill=tk.Y, padx=(0, 12))

        ttk.Label(left_frame, text="恐竜を選んでね", font=("Meiryo", 16, "bold")).pack(pady=(0, 12))

        self.trex_button = ttk.Button(left_frame, text="ティラノサウルス", command=self.show_trex)
        self.trex_button.pack(fill=tk.X, pady=6)

        self.triceratops_button = ttk.Button(left_frame, text="トリケラトプス", command=self.show_triceratops)
        self.triceratops_button.pack(fill=tk.X, pady=6)

        right_frame = ttk.Frame(main_frame, relief=tk.SOLID, borderwidth=1)
        right_frame.pack(side=tk.LEFT, fill=tk.BOTH, expand=True)

        ttk.Label(right_frame, text="説明", font=("Meiryo", 14, "bold")).pack(anchor=tk.W, padx=12, pady=(12, 4))

        self.description = tk.Text(
            right_frame,
            wrap=tk.WORD,
            width=40,
            height=12,
            font=("Meiryo", 12),
            padx=10,
            pady=10,
            state=tk.DISABLED,
            bg="#f9f9f9",
            relief=tk.FLAT,
        )
        self.description.pack(fill=tk.BOTH, expand=True, padx=12, pady=(0, 12))

        self._show_welcome_text()

    def _show_welcome_text(self):
        self._update_description(
            "左のボタンを押すと、恐竜の生息時代や特徴が表示されます。\n\n" 
            "ティラノサウルスかトリケラトプスを選んでみましょう。"
        )

    def _update_description(self, text: str):
        self.description.config(state=tk.NORMAL)
        self.description.delete("1.0", tk.END)
        self.description.insert(tk.END, text)
        self.description.config(state=tk.DISABLED)

    def show_trex(self):
        self._update_description(
            "ティラノサウルス:\n"
            "・約6800万〜6600万年前の白亜紀後期に生息\n"
            "・体長は約12メートルにもなる大きな肉食恐竜\n"
            "・強いあごと大きな歯で獲物を捕まえました\n"
            "・大きな後ろ足と小さな前あしが特徴です"
        )

    def show_triceratops(self):
        self._update_description(
            "トリケラトプス:\n"
            "・約6800万〜6600万年前の白亜紀後期に生息\n"
            "・三つの角と大きな襟飾りを持つ草食恐竜\n"
            "・頭の角で敵から身を守ったと考えられています\n"
            "・丈夫な体で群れを作って生活していた可能性があります"
        )

if __name__ == "__main__":
    app = DinosaurGuideApp()
    app.mainloop()
