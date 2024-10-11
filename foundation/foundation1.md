<div style="display: flex; gap: 1rem">

| Video                                |
|--------------------------------------|
| - _title: String                     |
| - _author: String                    |
| - _length: int                       |
| - _comments: List<Comment>           |
|                                      |
| + getCommentCount(): int             |
| + addComment(comment: Comment): void |
| + displayDetails(): void             |

| Comment                  |
|--------------------------|
| - _commenter: String     |
| - _text: String          |
|                          |
| + displayComment(): void |

</div>
