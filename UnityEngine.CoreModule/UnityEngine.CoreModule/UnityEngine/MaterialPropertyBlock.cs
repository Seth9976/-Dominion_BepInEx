using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Rendering;

namespace UnityEngine
{
	// Token: 0x020001EC RID: 492
	public sealed class MaterialPropertyBlock
	{
		// Token: 0x06001D9D RID: 7581 RVA: 0x00010A6C File Offset: 0x0000EC6C
		public void AddFloat(string name, float value)
		{
			this.SetFloat(Shader.PropertyToID(name), value);
		}

		// Token: 0x06001D9E RID: 7582 RVA: 0x00010A7D File Offset: 0x0000EC7D
		public void AddFloat(int nameID, float value)
		{
			this.SetFloat(nameID, value);
		}

		// Token: 0x06001D9F RID: 7583 RVA: 0x00010A89 File Offset: 0x0000EC89
		public void AddVector(string name, Vector4 value)
		{
			this.SetVector(Shader.PropertyToID(name), value);
		}

		// Token: 0x06001DA0 RID: 7584 RVA: 0x00010A9A File Offset: 0x0000EC9A
		public void AddVector(int nameID, Vector4 value)
		{
			this.SetVector(nameID, value);
		}

		// Token: 0x06001DA1 RID: 7585 RVA: 0x00010AA6 File Offset: 0x0000ECA6
		public void AddColor(string name, Color value)
		{
			this.SetColor(Shader.PropertyToID(name), value);
		}

		// Token: 0x06001DA2 RID: 7586 RVA: 0x00010AB7 File Offset: 0x0000ECB7
		public void AddColor(int nameID, Color value)
		{
			this.SetColor(nameID, value);
		}

		// Token: 0x06001DA3 RID: 7587 RVA: 0x00010AC3 File Offset: 0x0000ECC3
		public void AddMatrix(string name, Matrix4x4 value)
		{
			this.SetMatrix(Shader.PropertyToID(name), value);
		}

		// Token: 0x06001DA4 RID: 7588 RVA: 0x00010AD4 File Offset: 0x0000ECD4
		public void AddMatrix(int nameID, Matrix4x4 value)
		{
			this.SetMatrix(nameID, value);
		}

		// Token: 0x06001DA5 RID: 7589 RVA: 0x00010AE0 File Offset: 0x0000ECE0
		public void AddTexture(string name, Texture value)
		{
			this.SetTexture(Shader.PropertyToID(name), value);
		}

		// Token: 0x06001DA6 RID: 7590 RVA: 0x00010AF1 File Offset: 0x0000ECF1
		public void AddTexture(int nameID, Texture value)
		{
			this.SetTexture(nameID, value);
		}

		// Token: 0x06001DA7 RID: 7591 RVA: 0x00010AFD File Offset: 0x0000ECFD
		public int GetIntImpl(int name)
		{
			return MaterialPropertyBlock.GetIntImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
		}

		// Token: 0x06001DA8 RID: 7592 RVA: 0x00010B10 File Offset: 0x0000ED10
		public float GetFloatImpl(int name)
		{
			return MaterialPropertyBlock.GetFloatImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
		}

		// Token: 0x06001DA9 RID: 7593 RVA: 0x000637D0 File Offset: 0x000619D0
		public Vector4 GetVectorImpl(int name)
		{
			Vector4 vector;
			this.GetVectorImpl_Injected(name, out vector);
			return vector;
		}

		// Token: 0x06001DAA RID: 7594 RVA: 0x000637E8 File Offset: 0x000619E8
		public Color GetColorImpl(int name)
		{
			Color color;
			this.GetColorImpl_Injected(name, out color);
			return color;
		}

		// Token: 0x06001DAB RID: 7595 RVA: 0x00063800 File Offset: 0x00061A00
		public Matrix4x4 GetMatrixImpl(int name)
		{
			Matrix4x4 matrix4x;
			this.GetMatrixImpl_Injected(name, out matrix4x);
			return matrix4x;
		}

		// Token: 0x06001DAC RID: 7596 RVA: 0x00063818 File Offset: 0x00061A18
		public Texture GetTextureImpl(int name)
		{
			IntPtr intPtr = MaterialPropertyBlock.GetTextureImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
		}

		// Token: 0x06001DAD RID: 7597 RVA: 0x00010B23 File Offset: 0x0000ED23
		public bool HasPropertyImpl(int name)
		{
			return MaterialPropertyBlock.HasPropertyImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
		}

		// Token: 0x06001DAE RID: 7598 RVA: 0x00010B36 File Offset: 0x0000ED36
		public bool HasFloatImpl(int name)
		{
			return MaterialPropertyBlock.HasFloatImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
		}

		// Token: 0x06001DAF RID: 7599 RVA: 0x00010B49 File Offset: 0x0000ED49
		public bool HasIntImpl(int name)
		{
			return MaterialPropertyBlock.HasIntImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
		}

		// Token: 0x06001DB0 RID: 7600 RVA: 0x00010B5C File Offset: 0x0000ED5C
		public bool HasTextureImpl(int name)
		{
			return MaterialPropertyBlock.HasTextureImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
		}

		// Token: 0x06001DB1 RID: 7601 RVA: 0x00010B6F File Offset: 0x0000ED6F
		public bool HasMatrixImpl(int name)
		{
			return MaterialPropertyBlock.HasMatrixImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
		}

		// Token: 0x06001DB2 RID: 7602 RVA: 0x00010B82 File Offset: 0x0000ED82
		public bool HasVectorImpl(int name)
		{
			return MaterialPropertyBlock.HasVectorImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
		}

		// Token: 0x06001DB3 RID: 7603 RVA: 0x00010B95 File Offset: 0x0000ED95
		public bool HasBufferImpl(int name)
		{
			return MaterialPropertyBlock.HasBufferImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
		}

		// Token: 0x06001DB4 RID: 7604 RVA: 0x00010BA8 File Offset: 0x0000EDA8
		public bool HasConstantBufferImpl(int name)
		{
			return MaterialPropertyBlock.HasConstantBufferImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
		}

		// Token: 0x06001DB5 RID: 7605 RVA: 0x00010BBB File Offset: 0x0000EDBB
		public void SetIntImpl(int name, int value)
		{
			MaterialPropertyBlock.SetIntImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, value);
		}

		// Token: 0x06001DB6 RID: 7606 RVA: 0x00010BCF File Offset: 0x0000EDCF
		public void SetFloatImpl(int name, float value)
		{
			MaterialPropertyBlock.SetFloatImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, value);
		}

		// Token: 0x06001DB7 RID: 7607 RVA: 0x00010BE3 File Offset: 0x0000EDE3
		public void SetVectorImpl(int name, Vector4 value)
		{
			this.SetVectorImpl_Injected(name, ref value);
		}

		// Token: 0x06001DB8 RID: 7608 RVA: 0x00010BEE File Offset: 0x0000EDEE
		public void SetColorImpl(int name, Color value)
		{
			this.SetColorImpl_Injected(name, ref value);
		}

		// Token: 0x06001DB9 RID: 7609 RVA: 0x00010BF9 File Offset: 0x0000EDF9
		public void SetMatrixImpl(int name, Matrix4x4 value)
		{
			this.SetMatrixImpl_Injected(name, ref value);
		}

		// Token: 0x06001DBA RID: 7610 RVA: 0x00010C04 File Offset: 0x0000EE04
		public void SetTextureImpl(int name, Texture value)
		{
			MaterialPropertyBlock.SetTextureImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, IL2CPP.Il2CppObjectBaseToPtr(value));
		}

		// Token: 0x06001DBB RID: 7611 RVA: 0x00010C1D File Offset: 0x0000EE1D
		public void SetRenderTextureImpl(int name, RenderTexture value, UnityEngine.Rendering.RenderTextureSubElement element)
		{
			MaterialPropertyBlock.SetRenderTextureImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, IL2CPP.Il2CppObjectBaseToPtr(value), element);
		}

		// Token: 0x06001DBC RID: 7612 RVA: 0x00010C37 File Offset: 0x0000EE37
		public void SetBufferImpl(int name, ComputeBuffer value)
		{
			MaterialPropertyBlock.SetBufferImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, IL2CPP.Il2CppObjectBaseToPtr(value));
		}

		// Token: 0x06001DBD RID: 7613 RVA: 0x00010C50 File Offset: 0x0000EE50
		public void SetGraphicsBufferImpl(int name, GraphicsBuffer value)
		{
			MaterialPropertyBlock.SetGraphicsBufferImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, IL2CPP.Il2CppObjectBaseToPtr(value));
		}

		// Token: 0x06001DBE RID: 7614 RVA: 0x00010C69 File Offset: 0x0000EE69
		public void SetConstantBufferImpl(int name, ComputeBuffer value, int offset, int size)
		{
			MaterialPropertyBlock.SetConstantBufferImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, IL2CPP.Il2CppObjectBaseToPtr(value), offset, size);
		}

		// Token: 0x06001DBF RID: 7615 RVA: 0x00010C85 File Offset: 0x0000EE85
		public void SetConstantGraphicsBufferImpl(int name, GraphicsBuffer value, int offset, int size)
		{
			MaterialPropertyBlock.SetConstantGraphicsBufferImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, IL2CPP.Il2CppObjectBaseToPtr(value), offset, size);
		}

		// Token: 0x06001DC0 RID: 7616 RVA: 0x00010CA1 File Offset: 0x0000EEA1
		public void SetFloatArrayImpl(int name, Il2CppStructArray<float> values, int count)
		{
			MaterialPropertyBlock.SetFloatArrayImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, IL2CPP.Il2CppObjectBaseToPtr(values), count);
		}

		// Token: 0x06001DC1 RID: 7617 RVA: 0x00010CBB File Offset: 0x0000EEBB
		public void SetVectorArrayImpl(int name, Il2CppStructArray<Vector4> values, int count)
		{
			MaterialPropertyBlock.SetVectorArrayImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, IL2CPP.Il2CppObjectBaseToPtr(values), count);
		}

		// Token: 0x06001DC2 RID: 7618 RVA: 0x00010CD5 File Offset: 0x0000EED5
		public void SetMatrixArrayImpl(int name, Il2CppStructArray<Matrix4x4> values, int count)
		{
			MaterialPropertyBlock.SetMatrixArrayImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, IL2CPP.Il2CppObjectBaseToPtr(values), count);
		}

		// Token: 0x06001DC3 RID: 7619 RVA: 0x00063848 File Offset: 0x00061A48
		public Il2CppStructArray<float> GetFloatArrayImpl(int name)
		{
			IntPtr intPtr = MaterialPropertyBlock.GetFloatArrayImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
		}

		// Token: 0x06001DC4 RID: 7620 RVA: 0x00063878 File Offset: 0x00061A78
		public Il2CppStructArray<Vector4> GetVectorArrayImpl(int name)
		{
			IntPtr intPtr = MaterialPropertyBlock.GetVectorArrayImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector4>>(intPtr2) : null;
		}

		// Token: 0x06001DC5 RID: 7621 RVA: 0x000638A8 File Offset: 0x00061AA8
		public Il2CppStructArray<Matrix4x4> GetMatrixArrayImpl(int name)
		{
			IntPtr intPtr = MaterialPropertyBlock.GetMatrixArrayImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Matrix4x4>>(intPtr2) : null;
		}

		// Token: 0x06001DC6 RID: 7622 RVA: 0x00010CEF File Offset: 0x0000EEEF
		public int GetFloatArrayCountImpl(int name)
		{
			return MaterialPropertyBlock.GetFloatArrayCountImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
		}

		// Token: 0x06001DC7 RID: 7623 RVA: 0x00010D02 File Offset: 0x0000EF02
		public int GetVectorArrayCountImpl(int name)
		{
			return MaterialPropertyBlock.GetVectorArrayCountImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
		}

		// Token: 0x06001DC8 RID: 7624 RVA: 0x00010D15 File Offset: 0x0000EF15
		public int GetMatrixArrayCountImpl(int name)
		{
			return MaterialPropertyBlock.GetMatrixArrayCountImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name);
		}

		// Token: 0x06001DC9 RID: 7625 RVA: 0x00010D28 File Offset: 0x0000EF28
		public void ExtractFloatArrayImpl(int name, [Out] Il2CppStructArray<float> val)
		{
			MaterialPropertyBlock.ExtractFloatArrayImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, IL2CPP.Il2CppObjectBaseToPtr(val));
		}

		// Token: 0x06001DCA RID: 7626 RVA: 0x00010D41 File Offset: 0x0000EF41
		public void ExtractVectorArrayImpl(int name, [Out] Il2CppStructArray<Vector4> val)
		{
			MaterialPropertyBlock.ExtractVectorArrayImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, IL2CPP.Il2CppObjectBaseToPtr(val));
		}

		// Token: 0x06001DCB RID: 7627 RVA: 0x00010D5A File Offset: 0x0000EF5A
		public void ExtractMatrixArrayImpl(int name, [Out] Il2CppStructArray<Matrix4x4> val)
		{
			MaterialPropertyBlock.ExtractMatrixArrayImplDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, IL2CPP.Il2CppObjectBaseToPtr(val));
		}

		// Token: 0x06001DCC RID: 7628 RVA: 0x00010D73 File Offset: 0x0000EF73
		public static void Internal_CopyProbeOcclusionArrayFrom(MaterialPropertyBlock properties, Il2CppStructArray<Vector4> occlusionProbes, int sourceStart, int destStart, int count)
		{
			MaterialPropertyBlock.Internal_CopyProbeOcclusionArrayFromDelegateField(IL2CPP.Il2CppObjectBaseToPtr(properties), IL2CPP.Il2CppObjectBaseToPtr(occlusionProbes), sourceStart, destStart, count);
		}

		// Token: 0x06001DCD RID: 7629 RVA: 0x00010D8F File Offset: 0x0000EF8F
		public static IntPtr CreateImpl()
		{
			return MaterialPropertyBlock.CreateImplDelegateField();
		}

		// Token: 0x06001DCE RID: 7630 RVA: 0x00010D9B File Offset: 0x0000EF9B
		public static void DestroyImpl(IntPtr mpb)
		{
			MaterialPropertyBlock.DestroyImplDelegateField(mpb);
		}

		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x06001DCF RID: 7631 RVA: 0x00010DA8 File Offset: 0x0000EFA8
		public bool isEmpty
		{
			get
			{
				return MaterialPropertyBlock.get_isEmptyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06001DD0 RID: 7632 RVA: 0x00010DBA File Offset: 0x0000EFBA
		public void Clear(bool keepMemory)
		{
			MaterialPropertyBlock.ClearDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), keepMemory);
		}

		// Token: 0x06001DD1 RID: 7633 RVA: 0x00010DCD File Offset: 0x0000EFCD
		public void Clear()
		{
			this.Clear(true);
		}

		// Token: 0x06001DD2 RID: 7634 RVA: 0x000638D8 File Offset: 0x00061AD8
		public void SetFloatArray(int name, Il2CppStructArray<float> values, int count)
		{
			bool flag = values == null;
			if (flag)
			{
				throw new ArgumentNullException("values");
			}
			bool flag2 = values.Length == 0;
			if (flag2)
			{
				throw new ArgumentException("Zero-sized array is not allowed.");
			}
			bool flag3 = values.Length < count;
			if (flag3)
			{
				throw new ArgumentException("array has less elements than passed count.");
			}
			this.SetFloatArrayImpl(name, values, count);
		}

		// Token: 0x06001DD3 RID: 7635 RVA: 0x00063934 File Offset: 0x00061B34
		public void SetVectorArray(int name, Il2CppStructArray<Vector4> values, int count)
		{
			bool flag = values == null;
			if (flag)
			{
				throw new ArgumentNullException("values");
			}
			bool flag2 = values.Length == 0;
			if (flag2)
			{
				throw new ArgumentException("Zero-sized array is not allowed.");
			}
			bool flag3 = values.Length < count;
			if (flag3)
			{
				throw new ArgumentException("array has less elements than passed count.");
			}
			this.SetVectorArrayImpl(name, values, count);
		}

		// Token: 0x06001DD4 RID: 7636 RVA: 0x00063990 File Offset: 0x00061B90
		public void SetMatrixArray(int name, Il2CppStructArray<Matrix4x4> values, int count)
		{
			bool flag = values == null;
			if (flag)
			{
				throw new ArgumentNullException("values");
			}
			bool flag2 = values.Length == 0;
			if (flag2)
			{
				throw new ArgumentException("Zero-sized array is not allowed.");
			}
			bool flag3 = values.Length < count;
			if (flag3)
			{
				throw new ArgumentException("array has less elements than passed count.");
			}
			this.SetMatrixArrayImpl(name, values, count);
		}

		// Token: 0x06001DD5 RID: 7637 RVA: 0x000639EC File Offset: 0x00061BEC
		public void ExtractFloatArray(int name, List<float> values)
		{
			bool flag = values == null;
			if (flag)
			{
				throw new ArgumentNullException("values");
			}
			values.Clear();
			int floatArrayCountImpl = this.GetFloatArrayCountImpl(name);
			bool flag2 = floatArrayCountImpl > 0;
			if (flag2)
			{
				NoAllocHelpers.EnsureListElemCount<float>(values, floatArrayCountImpl);
				this.ExtractFloatArrayImpl(name, NoAllocHelpers.ExtractArrayFromList(values).Cast<Il2CppStructArray<float>>());
			}
		}

		// Token: 0x06001DD6 RID: 7638 RVA: 0x00063A44 File Offset: 0x00061C44
		public void ExtractVectorArray(int name, List<Vector4> values)
		{
			bool flag = values == null;
			if (flag)
			{
				throw new ArgumentNullException("values");
			}
			values.Clear();
			int vectorArrayCountImpl = this.GetVectorArrayCountImpl(name);
			bool flag2 = vectorArrayCountImpl > 0;
			if (flag2)
			{
				NoAllocHelpers.EnsureListElemCount<Vector4>(values, vectorArrayCountImpl);
				this.ExtractVectorArrayImpl(name, NoAllocHelpers.ExtractArrayFromList(values).Cast<Il2CppStructArray<Vector4>>());
			}
		}

		// Token: 0x06001DD7 RID: 7639 RVA: 0x00063A9C File Offset: 0x00061C9C
		public void ExtractMatrixArray(int name, List<Matrix4x4> values)
		{
			bool flag = values == null;
			if (flag)
			{
				throw new ArgumentNullException("values");
			}
			values.Clear();
			int matrixArrayCountImpl = this.GetMatrixArrayCountImpl(name);
			bool flag2 = matrixArrayCountImpl > 0;
			if (flag2)
			{
				NoAllocHelpers.EnsureListElemCount<Matrix4x4>(values, matrixArrayCountImpl);
				this.ExtractMatrixArrayImpl(name, NoAllocHelpers.ExtractArrayFromList(values).Cast<Il2CppStructArray<Matrix4x4>>());
			}
		}

		// Token: 0x06001DD8 RID: 7640 RVA: 0x00063AF4 File Offset: 0x00061CF4
		public ~MaterialPropertyBlock()
		{
			this.Dispose();
		}

		// Token: 0x06001DD9 RID: 7641 RVA: 0x00010DD8 File Offset: 0x0000EFD8
		public void Dispose()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001DDA RID: 7642 RVA: 0x00010DE5 File Offset: 0x0000EFE5
		public void SetInt(string name, int value)
		{
			this.SetFloatImpl(Shader.PropertyToID(name), (float)value);
		}

		// Token: 0x06001DDB RID: 7643 RVA: 0x00010DF7 File Offset: 0x0000EFF7
		public void SetInt(int nameID, int value)
		{
			this.SetFloatImpl(nameID, (float)value);
		}

		// Token: 0x06001DDC RID: 7644 RVA: 0x00010E04 File Offset: 0x0000F004
		public void SetFloat(string name, float value)
		{
			this.SetFloatImpl(Shader.PropertyToID(name), value);
		}

		// Token: 0x06001DDD RID: 7645 RVA: 0x00010E15 File Offset: 0x0000F015
		public void SetFloat(int nameID, float value)
		{
			this.SetFloatImpl(nameID, value);
		}

		// Token: 0x06001DDE RID: 7646 RVA: 0x00010E21 File Offset: 0x0000F021
		public void SetInteger(string name, int value)
		{
			this.SetIntImpl(Shader.PropertyToID(name), value);
		}

		// Token: 0x06001DDF RID: 7647 RVA: 0x00010E32 File Offset: 0x0000F032
		public void SetInteger(int nameID, int value)
		{
			this.SetIntImpl(nameID, value);
		}

		// Token: 0x06001DE0 RID: 7648 RVA: 0x00010E3E File Offset: 0x0000F03E
		public void SetVector(string name, Vector4 value)
		{
			this.SetVectorImpl(Shader.PropertyToID(name), value);
		}

		// Token: 0x06001DE1 RID: 7649 RVA: 0x00010E4F File Offset: 0x0000F04F
		public void SetVector(int nameID, Vector4 value)
		{
			this.SetVectorImpl(nameID, value);
		}

		// Token: 0x06001DE2 RID: 7650 RVA: 0x00010E5B File Offset: 0x0000F05B
		public void SetColor(string name, Color value)
		{
			this.SetColorImpl(Shader.PropertyToID(name), value);
		}

		// Token: 0x06001DE3 RID: 7651 RVA: 0x00010E6C File Offset: 0x0000F06C
		public void SetColor(int nameID, Color value)
		{
			this.SetColorImpl(nameID, value);
		}

		// Token: 0x06001DE4 RID: 7652 RVA: 0x00010E78 File Offset: 0x0000F078
		public void SetMatrix(string name, Matrix4x4 value)
		{
			this.SetMatrixImpl(Shader.PropertyToID(name), value);
		}

		// Token: 0x06001DE5 RID: 7653 RVA: 0x00010E89 File Offset: 0x0000F089
		public void SetMatrix(int nameID, Matrix4x4 value)
		{
			this.SetMatrixImpl(nameID, value);
		}

		// Token: 0x06001DE6 RID: 7654 RVA: 0x00010E95 File Offset: 0x0000F095
		public void SetBuffer(string name, ComputeBuffer value)
		{
			this.SetBufferImpl(Shader.PropertyToID(name), value);
		}

		// Token: 0x06001DE7 RID: 7655 RVA: 0x00010EA6 File Offset: 0x0000F0A6
		public void SetBuffer(int nameID, ComputeBuffer value)
		{
			this.SetBufferImpl(nameID, value);
		}

		// Token: 0x06001DE8 RID: 7656 RVA: 0x00010EB2 File Offset: 0x0000F0B2
		public void SetBuffer(string name, GraphicsBuffer value)
		{
			this.SetGraphicsBufferImpl(Shader.PropertyToID(name), value);
		}

		// Token: 0x06001DE9 RID: 7657 RVA: 0x00010EC3 File Offset: 0x0000F0C3
		public void SetBuffer(int nameID, GraphicsBuffer value)
		{
			this.SetGraphicsBufferImpl(nameID, value);
		}

		// Token: 0x06001DEA RID: 7658 RVA: 0x00010ECF File Offset: 0x0000F0CF
		public void SetTexture(string name, Texture value)
		{
			this.SetTextureImpl(Shader.PropertyToID(name), value);
		}

		// Token: 0x06001DEB RID: 7659 RVA: 0x00010EE0 File Offset: 0x0000F0E0
		public void SetTexture(int nameID, Texture value)
		{
			this.SetTextureImpl(nameID, value);
		}

		// Token: 0x06001DEC RID: 7660 RVA: 0x00010EEC File Offset: 0x0000F0EC
		public void SetTexture(string name, RenderTexture value, UnityEngine.Rendering.RenderTextureSubElement element)
		{
			this.SetRenderTextureImpl(Shader.PropertyToID(name), value, element);
		}

		// Token: 0x06001DED RID: 7661 RVA: 0x00010EFE File Offset: 0x0000F0FE
		public void SetTexture(int nameID, RenderTexture value, UnityEngine.Rendering.RenderTextureSubElement element)
		{
			this.SetRenderTextureImpl(nameID, value, element);
		}

		// Token: 0x06001DEE RID: 7662 RVA: 0x00010F0B File Offset: 0x0000F10B
		public void SetConstantBuffer(string name, ComputeBuffer value, int offset, int size)
		{
			this.SetConstantBufferImpl(Shader.PropertyToID(name), value, offset, size);
		}

		// Token: 0x06001DEF RID: 7663 RVA: 0x00010F1F File Offset: 0x0000F11F
		public void SetConstantBuffer(int nameID, ComputeBuffer value, int offset, int size)
		{
			this.SetConstantBufferImpl(nameID, value, offset, size);
		}

		// Token: 0x06001DF0 RID: 7664 RVA: 0x00010F2E File Offset: 0x0000F12E
		public void SetConstantBuffer(string name, GraphicsBuffer value, int offset, int size)
		{
			this.SetConstantGraphicsBufferImpl(Shader.PropertyToID(name), value, offset, size);
		}

		// Token: 0x06001DF1 RID: 7665 RVA: 0x00010F42 File Offset: 0x0000F142
		public void SetConstantBuffer(int nameID, GraphicsBuffer value, int offset, int size)
		{
			this.SetConstantGraphicsBufferImpl(nameID, value, offset, size);
		}

		// Token: 0x06001DF2 RID: 7666 RVA: 0x00010F51 File Offset: 0x0000F151
		public void SetFloatArray(string name, List<float> values)
		{
			this.SetFloatArray(Shader.PropertyToID(name), NoAllocHelpers.ExtractArrayFromListT<float>(values), values.Count);
		}

		// Token: 0x06001DF3 RID: 7667 RVA: 0x00010F6D File Offset: 0x0000F16D
		public void SetFloatArray(int nameID, List<float> values)
		{
			this.SetFloatArray(nameID, NoAllocHelpers.ExtractArrayFromListT<float>(values), values.Count);
		}

		// Token: 0x06001DF4 RID: 7668 RVA: 0x00010F84 File Offset: 0x0000F184
		public void SetFloatArray(string name, Il2CppStructArray<float> values)
		{
			this.SetFloatArray(Shader.PropertyToID(name), values, values.Length);
		}

		// Token: 0x06001DF5 RID: 7669 RVA: 0x00010F9C File Offset: 0x0000F19C
		public void SetFloatArray(int nameID, Il2CppStructArray<float> values)
		{
			this.SetFloatArray(nameID, values, values.Length);
		}

		// Token: 0x06001DF6 RID: 7670 RVA: 0x00010FAF File Offset: 0x0000F1AF
		public void SetVectorArray(string name, List<Vector4> values)
		{
			this.SetVectorArray(Shader.PropertyToID(name), NoAllocHelpers.ExtractArrayFromListT<Vector4>(values), values.Count);
		}

		// Token: 0x06001DF7 RID: 7671 RVA: 0x00010FCB File Offset: 0x0000F1CB
		public void SetVectorArray(int nameID, List<Vector4> values)
		{
			this.SetVectorArray(nameID, NoAllocHelpers.ExtractArrayFromListT<Vector4>(values), values.Count);
		}

		// Token: 0x06001DF8 RID: 7672 RVA: 0x00010FE2 File Offset: 0x0000F1E2
		public void SetVectorArray(string name, Il2CppStructArray<Vector4> values)
		{
			this.SetVectorArray(Shader.PropertyToID(name), values, values.Length);
		}

		// Token: 0x06001DF9 RID: 7673 RVA: 0x00010FFA File Offset: 0x0000F1FA
		public void SetVectorArray(int nameID, Il2CppStructArray<Vector4> values)
		{
			this.SetVectorArray(nameID, values, values.Length);
		}

		// Token: 0x06001DFA RID: 7674 RVA: 0x0001100D File Offset: 0x0000F20D
		public void SetMatrixArray(string name, List<Matrix4x4> values)
		{
			this.SetMatrixArray(Shader.PropertyToID(name), NoAllocHelpers.ExtractArrayFromListT<Matrix4x4>(values), values.Count);
		}

		// Token: 0x06001DFB RID: 7675 RVA: 0x00011029 File Offset: 0x0000F229
		public void SetMatrixArray(int nameID, List<Matrix4x4> values)
		{
			this.SetMatrixArray(nameID, NoAllocHelpers.ExtractArrayFromListT<Matrix4x4>(values), values.Count);
		}

		// Token: 0x06001DFC RID: 7676 RVA: 0x00011040 File Offset: 0x0000F240
		public void SetMatrixArray(string name, Il2CppStructArray<Matrix4x4> values)
		{
			this.SetMatrixArray(Shader.PropertyToID(name), values, values.Length);
		}

		// Token: 0x06001DFD RID: 7677 RVA: 0x00011058 File Offset: 0x0000F258
		public void SetMatrixArray(int nameID, Il2CppStructArray<Matrix4x4> values)
		{
			this.SetMatrixArray(nameID, values, values.Length);
		}

		// Token: 0x06001DFE RID: 7678 RVA: 0x00063B24 File Offset: 0x00061D24
		public bool HasProperty(string name)
		{
			return this.HasPropertyImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06001DFF RID: 7679 RVA: 0x00063B44 File Offset: 0x00061D44
		public bool HasProperty(int nameID)
		{
			return this.HasPropertyImpl(nameID);
		}

		// Token: 0x06001E00 RID: 7680 RVA: 0x00063B60 File Offset: 0x00061D60
		public bool HasInt(string name)
		{
			return this.HasFloatImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06001E01 RID: 7681 RVA: 0x00063B80 File Offset: 0x00061D80
		public bool HasInt(int nameID)
		{
			return this.HasFloatImpl(nameID);
		}

		// Token: 0x06001E02 RID: 7682 RVA: 0x00063B9C File Offset: 0x00061D9C
		public bool HasFloat(string name)
		{
			return this.HasFloatImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06001E03 RID: 7683 RVA: 0x00063BBC File Offset: 0x00061DBC
		public bool HasFloat(int nameID)
		{
			return this.HasFloatImpl(nameID);
		}

		// Token: 0x06001E04 RID: 7684 RVA: 0x00063BD8 File Offset: 0x00061DD8
		public bool HasInteger(string name)
		{
			return this.HasIntImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06001E05 RID: 7685 RVA: 0x00063BF8 File Offset: 0x00061DF8
		public bool HasInteger(int nameID)
		{
			return this.HasIntImpl(nameID);
		}

		// Token: 0x06001E06 RID: 7686 RVA: 0x00063C14 File Offset: 0x00061E14
		public bool HasTexture(string name)
		{
			return this.HasTextureImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06001E07 RID: 7687 RVA: 0x00063C34 File Offset: 0x00061E34
		public bool HasTexture(int nameID)
		{
			return this.HasTextureImpl(nameID);
		}

		// Token: 0x06001E08 RID: 7688 RVA: 0x00063C50 File Offset: 0x00061E50
		public bool HasMatrix(string name)
		{
			return this.HasMatrixImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06001E09 RID: 7689 RVA: 0x00063C70 File Offset: 0x00061E70
		public bool HasMatrix(int nameID)
		{
			return this.HasMatrixImpl(nameID);
		}

		// Token: 0x06001E0A RID: 7690 RVA: 0x00063C8C File Offset: 0x00061E8C
		public bool HasVector(string name)
		{
			return this.HasVectorImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06001E0B RID: 7691 RVA: 0x00063CAC File Offset: 0x00061EAC
		public bool HasVector(int nameID)
		{
			return this.HasVectorImpl(nameID);
		}

		// Token: 0x06001E0C RID: 7692 RVA: 0x00063CC8 File Offset: 0x00061EC8
		public bool HasColor(string name)
		{
			return this.HasVectorImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06001E0D RID: 7693 RVA: 0x00063CE8 File Offset: 0x00061EE8
		public bool HasColor(int nameID)
		{
			return this.HasVectorImpl(nameID);
		}

		// Token: 0x06001E0E RID: 7694 RVA: 0x00063D04 File Offset: 0x00061F04
		public bool HasBuffer(string name)
		{
			return this.HasBufferImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06001E0F RID: 7695 RVA: 0x00063D24 File Offset: 0x00061F24
		public bool HasBuffer(int nameID)
		{
			return this.HasBufferImpl(nameID);
		}

		// Token: 0x06001E10 RID: 7696 RVA: 0x00063D40 File Offset: 0x00061F40
		public bool HasConstantBuffer(string name)
		{
			return this.HasConstantBufferImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06001E11 RID: 7697 RVA: 0x00063D60 File Offset: 0x00061F60
		public bool HasConstantBuffer(int nameID)
		{
			return this.HasConstantBufferImpl(nameID);
		}

		// Token: 0x06001E12 RID: 7698 RVA: 0x00063D7C File Offset: 0x00061F7C
		public float GetFloat(string name)
		{
			return this.GetFloatImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06001E13 RID: 7699 RVA: 0x00063D9C File Offset: 0x00061F9C
		public float GetFloat(int nameID)
		{
			return this.GetFloatImpl(nameID);
		}

		// Token: 0x06001E14 RID: 7700 RVA: 0x00063DB8 File Offset: 0x00061FB8
		public int GetInt(string name)
		{
			return (int)this.GetFloatImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06001E15 RID: 7701 RVA: 0x00063DD8 File Offset: 0x00061FD8
		public int GetInt(int nameID)
		{
			return (int)this.GetFloatImpl(nameID);
		}

		// Token: 0x06001E16 RID: 7702 RVA: 0x00063DF4 File Offset: 0x00061FF4
		public int GetInteger(string name)
		{
			return this.GetIntImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06001E17 RID: 7703 RVA: 0x00063E14 File Offset: 0x00062014
		public int GetInteger(int nameID)
		{
			return this.GetIntImpl(nameID);
		}

		// Token: 0x06001E18 RID: 7704 RVA: 0x00063E30 File Offset: 0x00062030
		public Vector4 GetVector(string name)
		{
			return this.GetVectorImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06001E19 RID: 7705 RVA: 0x00063E50 File Offset: 0x00062050
		public Vector4 GetVector(int nameID)
		{
			return this.GetVectorImpl(nameID);
		}

		// Token: 0x06001E1A RID: 7706 RVA: 0x00063E6C File Offset: 0x0006206C
		public Color GetColor(string name)
		{
			return this.GetColorImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06001E1B RID: 7707 RVA: 0x00063E8C File Offset: 0x0006208C
		public Color GetColor(int nameID)
		{
			return this.GetColorImpl(nameID);
		}

		// Token: 0x06001E1C RID: 7708 RVA: 0x00063EA8 File Offset: 0x000620A8
		public Matrix4x4 GetMatrix(string name)
		{
			return this.GetMatrixImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06001E1D RID: 7709 RVA: 0x00063EC8 File Offset: 0x000620C8
		public Matrix4x4 GetMatrix(int nameID)
		{
			return this.GetMatrixImpl(nameID);
		}

		// Token: 0x06001E1E RID: 7710 RVA: 0x00063EE4 File Offset: 0x000620E4
		public Texture GetTexture(string name)
		{
			return this.GetTextureImpl(Shader.PropertyToID(name));
		}

		// Token: 0x06001E1F RID: 7711 RVA: 0x00063F04 File Offset: 0x00062104
		public Texture GetTexture(int nameID)
		{
			return this.GetTextureImpl(nameID);
		}

		// Token: 0x06001E20 RID: 7712 RVA: 0x00063F20 File Offset: 0x00062120
		public Il2CppStructArray<float> GetFloatArray(string name)
		{
			return this.GetFloatArray(Shader.PropertyToID(name));
		}

		// Token: 0x06001E21 RID: 7713 RVA: 0x00063F40 File Offset: 0x00062140
		public Il2CppStructArray<float> GetFloatArray(int nameID)
		{
			return (this.GetFloatArrayCountImpl(nameID) != 0) ? this.GetFloatArrayImpl(nameID) : null;
		}

		// Token: 0x06001E22 RID: 7714 RVA: 0x00063F68 File Offset: 0x00062168
		public Il2CppStructArray<Vector4> GetVectorArray(string name)
		{
			return this.GetVectorArray(Shader.PropertyToID(name));
		}

		// Token: 0x06001E23 RID: 7715 RVA: 0x00063F88 File Offset: 0x00062188
		public Il2CppStructArray<Vector4> GetVectorArray(int nameID)
		{
			return (this.GetVectorArrayCountImpl(nameID) != 0) ? this.GetVectorArrayImpl(nameID) : null;
		}

		// Token: 0x06001E24 RID: 7716 RVA: 0x00063FB0 File Offset: 0x000621B0
		public Il2CppStructArray<Matrix4x4> GetMatrixArray(string name)
		{
			return this.GetMatrixArray(Shader.PropertyToID(name));
		}

		// Token: 0x06001E25 RID: 7717 RVA: 0x00063FD0 File Offset: 0x000621D0
		public Il2CppStructArray<Matrix4x4> GetMatrixArray(int nameID)
		{
			return (this.GetMatrixArrayCountImpl(nameID) != 0) ? this.GetMatrixArrayImpl(nameID) : null;
		}

		// Token: 0x06001E26 RID: 7718 RVA: 0x0001106B File Offset: 0x0000F26B
		public void GetFloatArray(string name, List<float> values)
		{
			this.ExtractFloatArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x06001E27 RID: 7719 RVA: 0x0001107C File Offset: 0x0000F27C
		public void GetFloatArray(int nameID, List<float> values)
		{
			this.ExtractFloatArray(nameID, values);
		}

		// Token: 0x06001E28 RID: 7720 RVA: 0x00011088 File Offset: 0x0000F288
		public void GetVectorArray(string name, List<Vector4> values)
		{
			this.ExtractVectorArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x06001E29 RID: 7721 RVA: 0x00011099 File Offset: 0x0000F299
		public void GetVectorArray(int nameID, List<Vector4> values)
		{
			this.ExtractVectorArray(nameID, values);
		}

		// Token: 0x06001E2A RID: 7722 RVA: 0x000110A5 File Offset: 0x0000F2A5
		public void GetMatrixArray(string name, List<Matrix4x4> values)
		{
			this.ExtractMatrixArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x06001E2B RID: 7723 RVA: 0x000110B6 File Offset: 0x0000F2B6
		public void GetMatrixArray(int nameID, List<Matrix4x4> values)
		{
			this.ExtractMatrixArray(nameID, values);
		}

		// Token: 0x06001E2C RID: 7724 RVA: 0x00063FF8 File Offset: 0x000621F8
		public void CopyProbeOcclusionArrayFrom(List<Vector4> occlusionProbes)
		{
			bool flag = occlusionProbes == null;
			if (flag)
			{
				throw new ArgumentNullException("occlusionProbes");
			}
			this.CopyProbeOcclusionArrayFrom(NoAllocHelpers.ExtractArrayFromListT<Vector4>(occlusionProbes), 0, 0, occlusionProbes.Count);
		}

		// Token: 0x06001E2D RID: 7725 RVA: 0x00064030 File Offset: 0x00062230
		public void CopyProbeOcclusionArrayFrom(Il2CppStructArray<Vector4> occlusionProbes)
		{
			bool flag = occlusionProbes == null;
			if (flag)
			{
				throw new ArgumentNullException("occlusionProbes");
			}
			this.CopyProbeOcclusionArrayFrom(occlusionProbes, 0, 0, occlusionProbes.Length);
		}

		// Token: 0x06001E2E RID: 7726 RVA: 0x000110C2 File Offset: 0x0000F2C2
		public void CopyProbeOcclusionArrayFrom(List<Vector4> occlusionProbes, int sourceStart, int destStart, int count)
		{
			this.CopyProbeOcclusionArrayFrom(NoAllocHelpers.ExtractArrayFromListT<Vector4>(occlusionProbes), sourceStart, destStart, count);
		}

		// Token: 0x06001E2F RID: 7727 RVA: 0x00064064 File Offset: 0x00062264
		public void CopyProbeOcclusionArrayFrom(Il2CppStructArray<Vector4> occlusionProbes, int sourceStart, int destStart, int count)
		{
			bool flag = occlusionProbes == null;
			if (flag)
			{
				throw new ArgumentNullException("occlusionProbes");
			}
			bool flag2 = sourceStart < 0;
			if (flag2)
			{
				throw new ArgumentOutOfRangeException("sourceStart", "Argument sourceStart must not be negative.");
			}
			bool flag3 = destStart < 0;
			if (flag3)
			{
				throw new ArgumentOutOfRangeException("sourceStart", "Argument destStart must not be negative.");
			}
			bool flag4 = count < 0;
			if (flag4)
			{
				throw new ArgumentOutOfRangeException("count", "Argument count must not be negative.");
			}
			bool flag5 = occlusionProbes.Length < sourceStart + count;
			if (flag5)
			{
				throw new ArgumentOutOfRangeException("The specified source start index or count is out of the range.");
			}
			MaterialPropertyBlock.Internal_CopyProbeOcclusionArrayFrom(this, occlusionProbes, sourceStart, destStart, count);
		}

		// Token: 0x06001E30 RID: 7728 RVA: 0x000110D6 File Offset: 0x0000F2D6
		public void GetVectorImpl_Injected(int name, out Vector4 ret)
		{
			MaterialPropertyBlock.GetVectorImpl_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, out ret);
		}

		// Token: 0x06001E31 RID: 7729 RVA: 0x000110EA File Offset: 0x0000F2EA
		public void GetColorImpl_Injected(int name, out Color ret)
		{
			MaterialPropertyBlock.GetColorImpl_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, out ret);
		}

		// Token: 0x06001E32 RID: 7730 RVA: 0x000110FE File Offset: 0x0000F2FE
		public void GetMatrixImpl_Injected(int name, out Matrix4x4 ret)
		{
			MaterialPropertyBlock.GetMatrixImpl_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, out ret);
		}

		// Token: 0x06001E33 RID: 7731 RVA: 0x00011112 File Offset: 0x0000F312
		public void SetVectorImpl_Injected(int name, ref Vector4 value)
		{
			MaterialPropertyBlock.SetVectorImpl_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, ref value);
		}

		// Token: 0x06001E34 RID: 7732 RVA: 0x00011126 File Offset: 0x0000F326
		public void SetColorImpl_Injected(int name, ref Color value)
		{
			MaterialPropertyBlock.SetColorImpl_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, ref value);
		}

		// Token: 0x06001E35 RID: 7733 RVA: 0x0001113A File Offset: 0x0000F33A
		public void SetMatrixImpl_Injected(int name, ref Matrix4x4 value)
		{
			MaterialPropertyBlock.SetMatrixImpl_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), name, ref value);
		}

		// Token: 0x04001745 RID: 5957
		private static readonly MaterialPropertyBlock.GetIntImplDelegate GetIntImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.GetIntImplDelegate>("UnityEngine.MaterialPropertyBlock::GetIntImpl");

		// Token: 0x04001746 RID: 5958
		private static readonly MaterialPropertyBlock.GetFloatImplDelegate GetFloatImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.GetFloatImplDelegate>("UnityEngine.MaterialPropertyBlock::GetFloatImpl");

		// Token: 0x04001747 RID: 5959
		private static readonly MaterialPropertyBlock.GetTextureImplDelegate GetTextureImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.GetTextureImplDelegate>("UnityEngine.MaterialPropertyBlock::GetTextureImpl");

		// Token: 0x04001748 RID: 5960
		private static readonly MaterialPropertyBlock.HasPropertyImplDelegate HasPropertyImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.HasPropertyImplDelegate>("UnityEngine.MaterialPropertyBlock::HasPropertyImpl");

		// Token: 0x04001749 RID: 5961
		private static readonly MaterialPropertyBlock.HasFloatImplDelegate HasFloatImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.HasFloatImplDelegate>("UnityEngine.MaterialPropertyBlock::HasFloatImpl");

		// Token: 0x0400174A RID: 5962
		private static readonly MaterialPropertyBlock.HasIntImplDelegate HasIntImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.HasIntImplDelegate>("UnityEngine.MaterialPropertyBlock::HasIntImpl");

		// Token: 0x0400174B RID: 5963
		private static readonly MaterialPropertyBlock.HasTextureImplDelegate HasTextureImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.HasTextureImplDelegate>("UnityEngine.MaterialPropertyBlock::HasTextureImpl");

		// Token: 0x0400174C RID: 5964
		private static readonly MaterialPropertyBlock.HasMatrixImplDelegate HasMatrixImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.HasMatrixImplDelegate>("UnityEngine.MaterialPropertyBlock::HasMatrixImpl");

		// Token: 0x0400174D RID: 5965
		private static readonly MaterialPropertyBlock.HasVectorImplDelegate HasVectorImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.HasVectorImplDelegate>("UnityEngine.MaterialPropertyBlock::HasVectorImpl");

		// Token: 0x0400174E RID: 5966
		private static readonly MaterialPropertyBlock.HasBufferImplDelegate HasBufferImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.HasBufferImplDelegate>("UnityEngine.MaterialPropertyBlock::HasBufferImpl");

		// Token: 0x0400174F RID: 5967
		private static readonly MaterialPropertyBlock.HasConstantBufferImplDelegate HasConstantBufferImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.HasConstantBufferImplDelegate>("UnityEngine.MaterialPropertyBlock::HasConstantBufferImpl");

		// Token: 0x04001750 RID: 5968
		private static readonly MaterialPropertyBlock.SetIntImplDelegate SetIntImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.SetIntImplDelegate>("UnityEngine.MaterialPropertyBlock::SetIntImpl");

		// Token: 0x04001751 RID: 5969
		private static readonly MaterialPropertyBlock.SetFloatImplDelegate SetFloatImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.SetFloatImplDelegate>("UnityEngine.MaterialPropertyBlock::SetFloatImpl");

		// Token: 0x04001752 RID: 5970
		private static readonly MaterialPropertyBlock.SetTextureImplDelegate SetTextureImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.SetTextureImplDelegate>("UnityEngine.MaterialPropertyBlock::SetTextureImpl");

		// Token: 0x04001753 RID: 5971
		private static readonly MaterialPropertyBlock.SetRenderTextureImplDelegate SetRenderTextureImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.SetRenderTextureImplDelegate>("UnityEngine.MaterialPropertyBlock::SetRenderTextureImpl");

		// Token: 0x04001754 RID: 5972
		private static readonly MaterialPropertyBlock.SetBufferImplDelegate SetBufferImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.SetBufferImplDelegate>("UnityEngine.MaterialPropertyBlock::SetBufferImpl");

		// Token: 0x04001755 RID: 5973
		private static readonly MaterialPropertyBlock.SetGraphicsBufferImplDelegate SetGraphicsBufferImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.SetGraphicsBufferImplDelegate>("UnityEngine.MaterialPropertyBlock::SetGraphicsBufferImpl");

		// Token: 0x04001756 RID: 5974
		private static readonly MaterialPropertyBlock.SetConstantBufferImplDelegate SetConstantBufferImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.SetConstantBufferImplDelegate>("UnityEngine.MaterialPropertyBlock::SetConstantBufferImpl");

		// Token: 0x04001757 RID: 5975
		private static readonly MaterialPropertyBlock.SetConstantGraphicsBufferImplDelegate SetConstantGraphicsBufferImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.SetConstantGraphicsBufferImplDelegate>("UnityEngine.MaterialPropertyBlock::SetConstantGraphicsBufferImpl");

		// Token: 0x04001758 RID: 5976
		private static readonly MaterialPropertyBlock.SetFloatArrayImplDelegate SetFloatArrayImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.SetFloatArrayImplDelegate>("UnityEngine.MaterialPropertyBlock::SetFloatArrayImpl");

		// Token: 0x04001759 RID: 5977
		private static readonly MaterialPropertyBlock.SetVectorArrayImplDelegate SetVectorArrayImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.SetVectorArrayImplDelegate>("UnityEngine.MaterialPropertyBlock::SetVectorArrayImpl");

		// Token: 0x0400175A RID: 5978
		private static readonly MaterialPropertyBlock.SetMatrixArrayImplDelegate SetMatrixArrayImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.SetMatrixArrayImplDelegate>("UnityEngine.MaterialPropertyBlock::SetMatrixArrayImpl");

		// Token: 0x0400175B RID: 5979
		private static readonly MaterialPropertyBlock.GetFloatArrayImplDelegate GetFloatArrayImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.GetFloatArrayImplDelegate>("UnityEngine.MaterialPropertyBlock::GetFloatArrayImpl");

		// Token: 0x0400175C RID: 5980
		private static readonly MaterialPropertyBlock.GetVectorArrayImplDelegate GetVectorArrayImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.GetVectorArrayImplDelegate>("UnityEngine.MaterialPropertyBlock::GetVectorArrayImpl");

		// Token: 0x0400175D RID: 5981
		private static readonly MaterialPropertyBlock.GetMatrixArrayImplDelegate GetMatrixArrayImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.GetMatrixArrayImplDelegate>("UnityEngine.MaterialPropertyBlock::GetMatrixArrayImpl");

		// Token: 0x0400175E RID: 5982
		private static readonly MaterialPropertyBlock.GetFloatArrayCountImplDelegate GetFloatArrayCountImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.GetFloatArrayCountImplDelegate>("UnityEngine.MaterialPropertyBlock::GetFloatArrayCountImpl");

		// Token: 0x0400175F RID: 5983
		private static readonly MaterialPropertyBlock.GetVectorArrayCountImplDelegate GetVectorArrayCountImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.GetVectorArrayCountImplDelegate>("UnityEngine.MaterialPropertyBlock::GetVectorArrayCountImpl");

		// Token: 0x04001760 RID: 5984
		private static readonly MaterialPropertyBlock.GetMatrixArrayCountImplDelegate GetMatrixArrayCountImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.GetMatrixArrayCountImplDelegate>("UnityEngine.MaterialPropertyBlock::GetMatrixArrayCountImpl");

		// Token: 0x04001761 RID: 5985
		private static readonly MaterialPropertyBlock.ExtractFloatArrayImplDelegate ExtractFloatArrayImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.ExtractFloatArrayImplDelegate>("UnityEngine.MaterialPropertyBlock::ExtractFloatArrayImpl");

		// Token: 0x04001762 RID: 5986
		private static readonly MaterialPropertyBlock.ExtractVectorArrayImplDelegate ExtractVectorArrayImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.ExtractVectorArrayImplDelegate>("UnityEngine.MaterialPropertyBlock::ExtractVectorArrayImpl");

		// Token: 0x04001763 RID: 5987
		private static readonly MaterialPropertyBlock.ExtractMatrixArrayImplDelegate ExtractMatrixArrayImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.ExtractMatrixArrayImplDelegate>("UnityEngine.MaterialPropertyBlock::ExtractMatrixArrayImpl");

		// Token: 0x04001764 RID: 5988
		private static readonly MaterialPropertyBlock.Internal_CopyProbeOcclusionArrayFromDelegate Internal_CopyProbeOcclusionArrayFromDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.Internal_CopyProbeOcclusionArrayFromDelegate>("UnityEngine.MaterialPropertyBlock::Internal_CopyProbeOcclusionArrayFrom");

		// Token: 0x04001765 RID: 5989
		private static readonly MaterialPropertyBlock.CreateImplDelegate CreateImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.CreateImplDelegate>("UnityEngine.MaterialPropertyBlock::CreateImpl");

		// Token: 0x04001766 RID: 5990
		private static readonly MaterialPropertyBlock.DestroyImplDelegate DestroyImplDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.DestroyImplDelegate>("UnityEngine.MaterialPropertyBlock::DestroyImpl");

		// Token: 0x04001767 RID: 5991
		private static readonly MaterialPropertyBlock.get_isEmptyDelegate get_isEmptyDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.get_isEmptyDelegate>("UnityEngine.MaterialPropertyBlock::get_isEmpty");

		// Token: 0x04001768 RID: 5992
		private static readonly MaterialPropertyBlock.ClearDelegate ClearDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.ClearDelegate>("UnityEngine.MaterialPropertyBlock::Clear");

		// Token: 0x04001769 RID: 5993
		private static readonly MaterialPropertyBlock.GetVectorImpl_InjectedDelegate GetVectorImpl_InjectedDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.GetVectorImpl_InjectedDelegate>("UnityEngine.MaterialPropertyBlock::GetVectorImpl_Injected");

		// Token: 0x0400176A RID: 5994
		private static readonly MaterialPropertyBlock.GetColorImpl_InjectedDelegate GetColorImpl_InjectedDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.GetColorImpl_InjectedDelegate>("UnityEngine.MaterialPropertyBlock::GetColorImpl_Injected");

		// Token: 0x0400176B RID: 5995
		private static readonly MaterialPropertyBlock.GetMatrixImpl_InjectedDelegate GetMatrixImpl_InjectedDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.GetMatrixImpl_InjectedDelegate>("UnityEngine.MaterialPropertyBlock::GetMatrixImpl_Injected");

		// Token: 0x0400176C RID: 5996
		private static readonly MaterialPropertyBlock.SetVectorImpl_InjectedDelegate SetVectorImpl_InjectedDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.SetVectorImpl_InjectedDelegate>("UnityEngine.MaterialPropertyBlock::SetVectorImpl_Injected");

		// Token: 0x0400176D RID: 5997
		private static readonly MaterialPropertyBlock.SetColorImpl_InjectedDelegate SetColorImpl_InjectedDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.SetColorImpl_InjectedDelegate>("UnityEngine.MaterialPropertyBlock::SetColorImpl_Injected");

		// Token: 0x0400176E RID: 5998
		private static readonly MaterialPropertyBlock.SetMatrixImpl_InjectedDelegate SetMatrixImpl_InjectedDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.SetMatrixImpl_InjectedDelegate>("UnityEngine.MaterialPropertyBlock::SetMatrixImpl_Injected");

		// Token: 0x02000B5F RID: 2911
		// (Invoke) Token: 0x060034BE RID: 13502
		private delegate int GetIntImplDelegate(IntPtr @this, int name);

		// Token: 0x02000B60 RID: 2912
		// (Invoke) Token: 0x060034C0 RID: 13504
		private delegate float GetFloatImplDelegate(IntPtr @this, int name);

		// Token: 0x02000B61 RID: 2913
		// (Invoke) Token: 0x060034C2 RID: 13506
		private delegate IntPtr GetTextureImplDelegate(IntPtr @this, int name);

		// Token: 0x02000B62 RID: 2914
		// (Invoke) Token: 0x060034C4 RID: 13508
		private delegate bool HasPropertyImplDelegate(IntPtr @this, int name);

		// Token: 0x02000B63 RID: 2915
		// (Invoke) Token: 0x060034C6 RID: 13510
		private delegate bool HasFloatImplDelegate(IntPtr @this, int name);

		// Token: 0x02000B64 RID: 2916
		// (Invoke) Token: 0x060034C8 RID: 13512
		private delegate bool HasIntImplDelegate(IntPtr @this, int name);

		// Token: 0x02000B65 RID: 2917
		// (Invoke) Token: 0x060034CA RID: 13514
		private delegate bool HasTextureImplDelegate(IntPtr @this, int name);

		// Token: 0x02000B66 RID: 2918
		// (Invoke) Token: 0x060034CC RID: 13516
		private delegate bool HasMatrixImplDelegate(IntPtr @this, int name);

		// Token: 0x02000B67 RID: 2919
		// (Invoke) Token: 0x060034CE RID: 13518
		private delegate bool HasVectorImplDelegate(IntPtr @this, int name);

		// Token: 0x02000B68 RID: 2920
		// (Invoke) Token: 0x060034D0 RID: 13520
		private delegate bool HasBufferImplDelegate(IntPtr @this, int name);

		// Token: 0x02000B69 RID: 2921
		// (Invoke) Token: 0x060034D2 RID: 13522
		private delegate bool HasConstantBufferImplDelegate(IntPtr @this, int name);

		// Token: 0x02000B6A RID: 2922
		// (Invoke) Token: 0x060034D4 RID: 13524
		private delegate void SetIntImplDelegate(IntPtr @this, int name, int value);

		// Token: 0x02000B6B RID: 2923
		// (Invoke) Token: 0x060034D6 RID: 13526
		private delegate void SetFloatImplDelegate(IntPtr @this, int name, float value);

		// Token: 0x02000B6C RID: 2924
		// (Invoke) Token: 0x060034D8 RID: 13528
		private delegate void SetTextureImplDelegate(IntPtr @this, int name, IntPtr value);

		// Token: 0x02000B6D RID: 2925
		// (Invoke) Token: 0x060034DA RID: 13530
		private delegate void SetRenderTextureImplDelegate(IntPtr @this, int name, IntPtr value, UnityEngine.Rendering.RenderTextureSubElement element);

		// Token: 0x02000B6E RID: 2926
		// (Invoke) Token: 0x060034DC RID: 13532
		private delegate void SetBufferImplDelegate(IntPtr @this, int name, IntPtr value);

		// Token: 0x02000B6F RID: 2927
		// (Invoke) Token: 0x060034DE RID: 13534
		private delegate void SetGraphicsBufferImplDelegate(IntPtr @this, int name, IntPtr value);

		// Token: 0x02000B70 RID: 2928
		// (Invoke) Token: 0x060034E0 RID: 13536
		private delegate void SetConstantBufferImplDelegate(IntPtr @this, int name, IntPtr value, int offset, int size);

		// Token: 0x02000B71 RID: 2929
		// (Invoke) Token: 0x060034E2 RID: 13538
		private delegate void SetConstantGraphicsBufferImplDelegate(IntPtr @this, int name, IntPtr value, int offset, int size);

		// Token: 0x02000B72 RID: 2930
		// (Invoke) Token: 0x060034E4 RID: 13540
		private delegate void SetFloatArrayImplDelegate(IntPtr @this, int name, IntPtr values, int count);

		// Token: 0x02000B73 RID: 2931
		// (Invoke) Token: 0x060034E6 RID: 13542
		private delegate void SetVectorArrayImplDelegate(IntPtr @this, int name, IntPtr values, int count);

		// Token: 0x02000B74 RID: 2932
		// (Invoke) Token: 0x060034E8 RID: 13544
		private delegate void SetMatrixArrayImplDelegate(IntPtr @this, int name, IntPtr values, int count);

		// Token: 0x02000B75 RID: 2933
		// (Invoke) Token: 0x060034EA RID: 13546
		private delegate IntPtr GetFloatArrayImplDelegate(IntPtr @this, int name);

		// Token: 0x02000B76 RID: 2934
		// (Invoke) Token: 0x060034EC RID: 13548
		private delegate IntPtr GetVectorArrayImplDelegate(IntPtr @this, int name);

		// Token: 0x02000B77 RID: 2935
		// (Invoke) Token: 0x060034EE RID: 13550
		private delegate IntPtr GetMatrixArrayImplDelegate(IntPtr @this, int name);

		// Token: 0x02000B78 RID: 2936
		// (Invoke) Token: 0x060034F0 RID: 13552
		private delegate int GetFloatArrayCountImplDelegate(IntPtr @this, int name);

		// Token: 0x02000B79 RID: 2937
		// (Invoke) Token: 0x060034F2 RID: 13554
		private delegate int GetVectorArrayCountImplDelegate(IntPtr @this, int name);

		// Token: 0x02000B7A RID: 2938
		// (Invoke) Token: 0x060034F4 RID: 13556
		private delegate int GetMatrixArrayCountImplDelegate(IntPtr @this, int name);

		// Token: 0x02000B7B RID: 2939
		// (Invoke) Token: 0x060034F6 RID: 13558
		private delegate void ExtractFloatArrayImplDelegate(IntPtr @this, int name, [Out] IntPtr val);

		// Token: 0x02000B7C RID: 2940
		// (Invoke) Token: 0x060034F8 RID: 13560
		private delegate void ExtractVectorArrayImplDelegate(IntPtr @this, int name, [Out] IntPtr val);

		// Token: 0x02000B7D RID: 2941
		// (Invoke) Token: 0x060034FA RID: 13562
		private delegate void ExtractMatrixArrayImplDelegate(IntPtr @this, int name, [Out] IntPtr val);

		// Token: 0x02000B7E RID: 2942
		// (Invoke) Token: 0x060034FC RID: 13564
		private delegate void Internal_CopyProbeOcclusionArrayFromDelegate(IntPtr properties, IntPtr occlusionProbes, int sourceStart, int destStart, int count);

		// Token: 0x02000B7F RID: 2943
		// (Invoke) Token: 0x060034FE RID: 13566
		private delegate IntPtr CreateImplDelegate();

		// Token: 0x02000B80 RID: 2944
		// (Invoke) Token: 0x06003500 RID: 13568
		private delegate void DestroyImplDelegate(IntPtr mpb);

		// Token: 0x02000B81 RID: 2945
		// (Invoke) Token: 0x06003502 RID: 13570
		private delegate bool get_isEmptyDelegate(IntPtr @this);

		// Token: 0x02000B82 RID: 2946
		// (Invoke) Token: 0x06003504 RID: 13572
		private delegate void ClearDelegate(IntPtr @this, bool keepMemory);

		// Token: 0x02000B83 RID: 2947
		// (Invoke) Token: 0x06003506 RID: 13574
		private delegate void GetVectorImpl_InjectedDelegate(IntPtr @this, int name, [Out] IntPtr ret);

		// Token: 0x02000B84 RID: 2948
		// (Invoke) Token: 0x06003508 RID: 13576
		private delegate void GetColorImpl_InjectedDelegate(IntPtr @this, int name, [Out] IntPtr ret);

		// Token: 0x02000B85 RID: 2949
		// (Invoke) Token: 0x0600350A RID: 13578
		private delegate void GetMatrixImpl_InjectedDelegate(IntPtr @this, int name, [Out] IntPtr ret);

		// Token: 0x02000B86 RID: 2950
		// (Invoke) Token: 0x0600350C RID: 13580
		private delegate void SetVectorImpl_InjectedDelegate(IntPtr @this, int name, IntPtr value);

		// Token: 0x02000B87 RID: 2951
		// (Invoke) Token: 0x0600350E RID: 13582
		private delegate void SetColorImpl_InjectedDelegate(IntPtr @this, int name, IntPtr value);

		// Token: 0x02000B88 RID: 2952
		// (Invoke) Token: 0x06003510 RID: 13584
		private delegate void SetMatrixImpl_InjectedDelegate(IntPtr @this, int name, IntPtr value);
	}
}
