using System;

namespace UnityEngine.UIElements
{
	// Token: 0x02000141 RID: 321
	public class Image : VisualElement
	{
		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x06000E95 RID: 3733 RVA: 0x000094B3 File Offset: 0x000076B3
		// (set) Token: 0x06000E96 RID: 3734 RVA: 0x000094C0 File Offset: 0x000076C0
		public Texture image
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x06000E97 RID: 3735 RVA: 0x000094CD File Offset: 0x000076CD
		// (set) Token: 0x06000E98 RID: 3736 RVA: 0x000094DA File Offset: 0x000076DA
		public Sprite sprite
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x06000E99 RID: 3737 RVA: 0x000094E7 File Offset: 0x000076E7
		// (set) Token: 0x06000E9A RID: 3738 RVA: 0x000094F4 File Offset: 0x000076F4
		public VectorImage vectorImage
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x06000E9B RID: 3739 RVA: 0x00035BB0 File Offset: 0x00033DB0
		// (set) Token: 0x06000E9C RID: 3740 RVA: 0x00035BC8 File Offset: 0x00033DC8
		public Rect sourceRect
		{
			get
			{
				return this.GetSourceRect();
			}
			set
			{
				bool flag = this.sprite != null;
				if (flag)
				{
					Debug.LogError("Cannot set sourceRect on a sprite image");
				}
				else
				{
					this.CalculateUV(value);
				}
			}
		}

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x06000E9D RID: 3741 RVA: 0x00009501 File Offset: 0x00007701
		// (set) Token: 0x06000E9E RID: 3742 RVA: 0x0000950E File Offset: 0x0000770E
		public Rect uv
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x06000E9F RID: 3743 RVA: 0x0000951B File Offset: 0x0000771B
		// (set) Token: 0x06000EA0 RID: 3744 RVA: 0x00009528 File Offset: 0x00007728
		public ScaleMode scaleMode
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x06000EA1 RID: 3745 RVA: 0x00009535 File Offset: 0x00007735
		// (set) Token: 0x06000EA2 RID: 3746 RVA: 0x00009542 File Offset: 0x00007742
		public Color tintColor
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06000EA3 RID: 3747 RVA: 0x00035BFC File Offset: 0x00033DFC
		public Vector2 GetTextureDisplaySize(Texture texture)
		{
			Vector2 zero = Vector2.zero;
			bool flag = texture != null;
			if (flag)
			{
				zero = new Vector2((float)texture.width, (float)texture.height);
			}
			return zero;
		}

		// Token: 0x06000EA4 RID: 3748 RVA: 0x00035C38 File Offset: 0x00033E38
		public Vector2 GetTextureDisplaySize(Sprite sprite)
		{
			Vector2 vector = Vector2.zero;
			bool flag = sprite != null;
			if (flag)
			{
				vector = sprite.bounds.size * sprite.pixelsPerUnit;
			}
			return vector;
		}

		// Token: 0x06000EA5 RID: 3749 RVA: 0x00035C7C File Offset: 0x00033E7C
		public override Vector2 DoMeasure(float desiredWidth, VisualElement.MeasureMode widthMode, float desiredHeight, VisualElement.MeasureMode heightMode)
		{
			float num = float.NaN;
			float num2 = float.NaN;
			bool flag = this.image == null && this.sprite == null && this.vectorImage == null;
			Vector2 vector;
			if (flag)
			{
				vector = new Vector2(num, num2);
			}
			else
			{
				Vector2 vector2 = Vector2.zero;
				bool flag2 = this.image != null;
				if (flag2)
				{
					vector2 = this.GetTextureDisplaySize(this.image);
				}
				else
				{
					bool flag3 = this.sprite != null;
					if (flag3)
					{
						vector2 = this.GetTextureDisplaySize(this.sprite);
					}
					else
					{
						vector2 = this.vectorImage.size;
					}
				}
				Rect sourceRect = this.sourceRect;
				bool flag4 = sourceRect != Rect.zero;
				num = (flag4 ? sourceRect.width : vector2.x);
				num2 = (flag4 ? sourceRect.height : vector2.y);
				bool flag5 = widthMode == VisualElement.MeasureMode.AtMost;
				if (flag5)
				{
					num = Mathf.Min(num, desiredWidth);
				}
				bool flag6 = heightMode == VisualElement.MeasureMode.AtMost;
				if (flag6)
				{
					num2 = Mathf.Min(num2, desiredHeight);
				}
				vector = new Vector2(num, num2);
			}
			return vector;
		}

		// Token: 0x06000EA6 RID: 3750 RVA: 0x0000954F File Offset: 0x0000774F
		public void OnGenerateVisualContent(MeshGenerationContext mgc)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000EA7 RID: 3751 RVA: 0x0000955C File Offset: 0x0000775C
		public void OnCustomStyleResolved(CustomStyleResolvedEvent e)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000EA8 RID: 3752 RVA: 0x00009569 File Offset: 0x00007769
		public void CalculateUV(Rect srcRect)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000EA9 RID: 3753 RVA: 0x00035D9C File Offset: 0x00033F9C
		public Rect GetSourceRect()
		{
			Rect zero = Rect.zero;
			Vector2 vector = Vector2.zero;
			Texture image = this.image;
			bool flag = image != null;
			if (flag)
			{
				vector = this.GetTextureDisplaySize(image);
			}
			VectorImage vectorImage = this.vectorImage;
			bool flag2 = vectorImage != null;
			if (flag2)
			{
				vector = vectorImage.size;
			}
			bool flag3 = vector != Vector2.zero;
			if (flag3)
			{
				zero.x = this.uv.x * vector.x;
				zero.width = this.uv.width * vector.x;
				zero.y = (1f - this.uv.y - this.uv.height) * vector.y;
				zero.height = this.uv.height * vector.y;
			}
			return zero;
		}

		// Token: 0x02000251 RID: 593
		public new class UxmlFactory : UxmlFactory<Image, Image.UxmlTraits>
		{
		}

		// Token: 0x02000252 RID: 594
		public new class UxmlTraits : VisualElement.UxmlTraits
		{
			// Token: 0x020002A3 RID: 675
			public sealed class <get_uxmlChildElementsDescription>d__1
			{
			}
		}
	}
}
