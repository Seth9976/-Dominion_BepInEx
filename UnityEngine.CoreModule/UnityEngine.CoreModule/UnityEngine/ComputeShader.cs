using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Rendering;

namespace UnityEngine
{
	// Token: 0x020000D0 RID: 208
	public sealed class ComputeShader : Object
	{
		// Token: 0x060011A3 RID: 4515 RVA: 0x0004772C File Offset: 0x0004592C
		// Note: this type is marked as 'beforefieldinit'.
		static ComputeShader()
		{
			Il2CppClassPointerStore<ComputeShader>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ComputeShader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ComputeShader>.NativeClassPtr);
			ComputeShader.NativeMethodInfoPtr_FindKernel_Public_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeShader>.NativeClassPtr, 100664541);
			ComputeShader.HasKernelDelegateField = IL2CPP.ResolveICall<ComputeShader.HasKernelDelegate>("UnityEngine.ComputeShader::HasKernel");
			ComputeShader.SetFloatDelegateField = IL2CPP.ResolveICall<ComputeShader.SetFloatDelegate>("UnityEngine.ComputeShader::SetFloat");
			ComputeShader.SetIntDelegateField = IL2CPP.ResolveICall<ComputeShader.SetIntDelegate>("UnityEngine.ComputeShader::SetInt");
			ComputeShader.SetFloatArrayDelegateField = IL2CPP.ResolveICall<ComputeShader.SetFloatArrayDelegate>("UnityEngine.ComputeShader::SetFloatArray");
			ComputeShader.SetIntArrayDelegateField = IL2CPP.ResolveICall<ComputeShader.SetIntArrayDelegate>("UnityEngine.ComputeShader::SetIntArray");
			ComputeShader.SetVectorArrayDelegateField = IL2CPP.ResolveICall<ComputeShader.SetVectorArrayDelegate>("UnityEngine.ComputeShader::SetVectorArray");
			ComputeShader.SetMatrixArrayDelegateField = IL2CPP.ResolveICall<ComputeShader.SetMatrixArrayDelegate>("UnityEngine.ComputeShader::SetMatrixArray");
			ComputeShader.SetTextureDelegateField = IL2CPP.ResolveICall<ComputeShader.SetTextureDelegate>("UnityEngine.ComputeShader::SetTexture");
			ComputeShader.SetRenderTextureDelegateField = IL2CPP.ResolveICall<ComputeShader.SetRenderTextureDelegate>("UnityEngine.ComputeShader::SetRenderTexture");
			ComputeShader.SetTextureFromGlobalDelegateField = IL2CPP.ResolveICall<ComputeShader.SetTextureFromGlobalDelegate>("UnityEngine.ComputeShader::SetTextureFromGlobal");
			ComputeShader.Internal_SetBufferDelegateField = IL2CPP.ResolveICall<ComputeShader.Internal_SetBufferDelegate>("UnityEngine.ComputeShader::Internal_SetBuffer");
			ComputeShader.Internal_SetGraphicsBufferDelegateField = IL2CPP.ResolveICall<ComputeShader.Internal_SetGraphicsBufferDelegate>("UnityEngine.ComputeShader::Internal_SetGraphicsBuffer");
			ComputeShader.SetConstantComputeBufferDelegateField = IL2CPP.ResolveICall<ComputeShader.SetConstantComputeBufferDelegate>("UnityEngine.ComputeShader::SetConstantComputeBuffer");
			ComputeShader.SetConstantGraphicsBufferDelegateField = IL2CPP.ResolveICall<ComputeShader.SetConstantGraphicsBufferDelegate>("UnityEngine.ComputeShader::SetConstantGraphicsBuffer");
			ComputeShader.GetKernelThreadGroupSizesDelegateField = IL2CPP.ResolveICall<ComputeShader.GetKernelThreadGroupSizesDelegate>("UnityEngine.ComputeShader::GetKernelThreadGroupSizes");
			ComputeShader.DispatchDelegateField = IL2CPP.ResolveICall<ComputeShader.DispatchDelegate>("UnityEngine.ComputeShader::Dispatch");
			ComputeShader.Internal_DispatchIndirectDelegateField = IL2CPP.ResolveICall<ComputeShader.Internal_DispatchIndirectDelegate>("UnityEngine.ComputeShader::Internal_DispatchIndirect");
			ComputeShader.Internal_DispatchIndirectGraphicsBufferDelegateField = IL2CPP.ResolveICall<ComputeShader.Internal_DispatchIndirectGraphicsBufferDelegate>("UnityEngine.ComputeShader::Internal_DispatchIndirectGraphicsBuffer");
			ComputeShader.EnableKeywordDelegateField = IL2CPP.ResolveICall<ComputeShader.EnableKeywordDelegate>("UnityEngine.ComputeShader::EnableKeyword");
			ComputeShader.DisableKeywordDelegateField = IL2CPP.ResolveICall<ComputeShader.DisableKeywordDelegate>("UnityEngine.ComputeShader::DisableKeyword");
			ComputeShader.IsKeywordEnabledDelegateField = IL2CPP.ResolveICall<ComputeShader.IsKeywordEnabledDelegate>("UnityEngine.ComputeShader::IsKeywordEnabled");
			ComputeShader.IsSupportedDelegateField = IL2CPP.ResolveICall<ComputeShader.IsSupportedDelegate>("UnityEngine.ComputeShader::IsSupported");
			ComputeShader.GetShaderKeywordsDelegateField = IL2CPP.ResolveICall<ComputeShader.GetShaderKeywordsDelegate>("UnityEngine.ComputeShader::GetShaderKeywords");
			ComputeShader.SetShaderKeywordsDelegateField = IL2CPP.ResolveICall<ComputeShader.SetShaderKeywordsDelegate>("UnityEngine.ComputeShader::SetShaderKeywords");
			ComputeShader.SetVector_InjectedDelegateField = IL2CPP.ResolveICall<ComputeShader.SetVector_InjectedDelegate>("UnityEngine.ComputeShader::SetVector_Injected");
			ComputeShader.SetMatrix_InjectedDelegateField = IL2CPP.ResolveICall<ComputeShader.SetMatrix_InjectedDelegate>("UnityEngine.ComputeShader::SetMatrix_Injected");
		}

		// Token: 0x060011A4 RID: 4516 RVA: 0x000478F8 File Offset: 0x00045AF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76648, XrefRangeEnd = 76650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FindKernel(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputeShader.NativeMethodInfoPtr_FindKernel_Public_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011A5 RID: 4517 RVA: 0x0000A908 File Offset: 0x00008B08
		public ComputeShader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060011A6 RID: 4518 RVA: 0x0000A911 File Offset: 0x00008B11
		public bool HasKernel(string name)
		{
			return ComputeShader.HasKernelDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x060011A7 RID: 4519 RVA: 0x0000A929 File Offset: 0x00008B29
		public void SetFloat(int nameID, float val)
		{
			ComputeShader.SetFloatDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, val);
		}

		// Token: 0x060011A8 RID: 4520 RVA: 0x0000A93D File Offset: 0x00008B3D
		public void SetInt(int nameID, int val)
		{
			ComputeShader.SetIntDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, val);
		}

		// Token: 0x060011A9 RID: 4521 RVA: 0x0000A951 File Offset: 0x00008B51
		public void SetVector(int nameID, Vector4 val)
		{
			this.SetVector_Injected(nameID, ref val);
		}

		// Token: 0x060011AA RID: 4522 RVA: 0x0000A95C File Offset: 0x00008B5C
		public void SetMatrix(int nameID, Matrix4x4 val)
		{
			this.SetMatrix_Injected(nameID, ref val);
		}

		// Token: 0x060011AB RID: 4523 RVA: 0x0000A967 File Offset: 0x00008B67
		public void SetFloatArray(int nameID, Il2CppStructArray<float> values)
		{
			ComputeShader.SetFloatArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(values));
		}

		// Token: 0x060011AC RID: 4524 RVA: 0x0000A980 File Offset: 0x00008B80
		public void SetIntArray(int nameID, Il2CppStructArray<int> values)
		{
			ComputeShader.SetIntArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(values));
		}

		// Token: 0x060011AD RID: 4525 RVA: 0x0000A999 File Offset: 0x00008B99
		public void SetVectorArray(int nameID, Il2CppStructArray<Vector4> values)
		{
			ComputeShader.SetVectorArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(values));
		}

		// Token: 0x060011AE RID: 4526 RVA: 0x0000A9B2 File Offset: 0x00008BB2
		public void SetMatrixArray(int nameID, Il2CppStructArray<Matrix4x4> values)
		{
			ComputeShader.SetMatrixArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(values));
		}

		// Token: 0x060011AF RID: 4527 RVA: 0x0000A9CB File Offset: 0x00008BCB
		public void SetTexture(int kernelIndex, int nameID, Texture texture, int mipLevel)
		{
			ComputeShader.SetTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), kernelIndex, nameID, IL2CPP.Il2CppObjectBaseToPtr(texture), mipLevel);
		}

		// Token: 0x060011B0 RID: 4528 RVA: 0x0000A9E7 File Offset: 0x00008BE7
		public void SetRenderTexture(int kernelIndex, int nameID, RenderTexture texture, int mipLevel, UnityEngine.Rendering.RenderTextureSubElement element)
		{
			ComputeShader.SetRenderTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), kernelIndex, nameID, IL2CPP.Il2CppObjectBaseToPtr(texture), mipLevel, element);
		}

		// Token: 0x060011B1 RID: 4529 RVA: 0x0000AA05 File Offset: 0x00008C05
		public void SetTextureFromGlobal(int kernelIndex, int nameID, int globalTextureNameID)
		{
			ComputeShader.SetTextureFromGlobalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), kernelIndex, nameID, globalTextureNameID);
		}

		// Token: 0x060011B2 RID: 4530 RVA: 0x0000AA1A File Offset: 0x00008C1A
		public void Internal_SetBuffer(int kernelIndex, int nameID, ComputeBuffer buffer)
		{
			ComputeShader.Internal_SetBufferDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), kernelIndex, nameID, IL2CPP.Il2CppObjectBaseToPtr(buffer));
		}

		// Token: 0x060011B3 RID: 4531 RVA: 0x0000AA34 File Offset: 0x00008C34
		public void Internal_SetGraphicsBuffer(int kernelIndex, int nameID, GraphicsBuffer buffer)
		{
			ComputeShader.Internal_SetGraphicsBufferDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), kernelIndex, nameID, IL2CPP.Il2CppObjectBaseToPtr(buffer));
		}

		// Token: 0x060011B4 RID: 4532 RVA: 0x0000AA4E File Offset: 0x00008C4E
		public void SetBuffer(int kernelIndex, int nameID, ComputeBuffer buffer)
		{
			this.Internal_SetBuffer(kernelIndex, nameID, buffer);
		}

		// Token: 0x060011B5 RID: 4533 RVA: 0x0000AA5B File Offset: 0x00008C5B
		public void SetBuffer(int kernelIndex, int nameID, GraphicsBuffer buffer)
		{
			this.Internal_SetGraphicsBuffer(kernelIndex, nameID, buffer);
		}

		// Token: 0x060011B6 RID: 4534 RVA: 0x0000AA68 File Offset: 0x00008C68
		public void SetConstantComputeBuffer(int nameID, ComputeBuffer buffer, int offset, int size)
		{
			ComputeShader.SetConstantComputeBufferDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(buffer), offset, size);
		}

		// Token: 0x060011B7 RID: 4535 RVA: 0x0000AA84 File Offset: 0x00008C84
		public void SetConstantGraphicsBuffer(int nameID, GraphicsBuffer buffer, int offset, int size)
		{
			ComputeShader.SetConstantGraphicsBufferDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(buffer), offset, size);
		}

		// Token: 0x060011B8 RID: 4536 RVA: 0x0000AAA0 File Offset: 0x00008CA0
		public void GetKernelThreadGroupSizes(int kernelIndex, out uint x, out uint y, out uint z)
		{
			ComputeShader.GetKernelThreadGroupSizesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), kernelIndex, out x, out y, out z);
		}

		// Token: 0x060011B9 RID: 4537 RVA: 0x0000AAB7 File Offset: 0x00008CB7
		public void Dispatch(int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ)
		{
			ComputeShader.DispatchDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), kernelIndex, threadGroupsX, threadGroupsY, threadGroupsZ);
		}

		// Token: 0x060011BA RID: 4538 RVA: 0x0000AACE File Offset: 0x00008CCE
		public void Internal_DispatchIndirect(int kernelIndex, ComputeBuffer argsBuffer, uint argsOffset)
		{
			ComputeShader.Internal_DispatchIndirectDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), kernelIndex, IL2CPP.Il2CppObjectBaseToPtr(argsBuffer), argsOffset);
		}

		// Token: 0x060011BB RID: 4539 RVA: 0x0000AAE8 File Offset: 0x00008CE8
		public void Internal_DispatchIndirectGraphicsBuffer(int kernelIndex, GraphicsBuffer argsBuffer, uint argsOffset)
		{
			ComputeShader.Internal_DispatchIndirectGraphicsBufferDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), kernelIndex, IL2CPP.Il2CppObjectBaseToPtr(argsBuffer), argsOffset);
		}

		// Token: 0x060011BC RID: 4540 RVA: 0x0000AB02 File Offset: 0x00008D02
		public void EnableKeyword(string keyword)
		{
			ComputeShader.EnableKeywordDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(keyword));
		}

		// Token: 0x060011BD RID: 4541 RVA: 0x0000AB1A File Offset: 0x00008D1A
		public void DisableKeyword(string keyword)
		{
			ComputeShader.DisableKeywordDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(keyword));
		}

		// Token: 0x060011BE RID: 4542 RVA: 0x0000AB32 File Offset: 0x00008D32
		public bool IsKeywordEnabled(string keyword)
		{
			return ComputeShader.IsKeywordEnabledDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(keyword));
		}

		// Token: 0x060011BF RID: 4543 RVA: 0x0000AB4A File Offset: 0x00008D4A
		public bool IsSupported(int kernelIndex)
		{
			return ComputeShader.IsSupportedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), kernelIndex);
		}

		// Token: 0x060011C0 RID: 4544 RVA: 0x00047948 File Offset: 0x00045B48
		public Il2CppStringArray GetShaderKeywords()
		{
			IntPtr intPtr = ComputeShader.GetShaderKeywordsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}

		// Token: 0x060011C1 RID: 4545 RVA: 0x0000AB5D File Offset: 0x00008D5D
		public void SetShaderKeywords(Il2CppStringArray names)
		{
			ComputeShader.SetShaderKeywordsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(names));
		}

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x060011C2 RID: 4546 RVA: 0x00047974 File Offset: 0x00045B74
		// (set) Token: 0x060011C3 RID: 4547 RVA: 0x0000AB75 File Offset: 0x00008D75
		public Il2CppStringArray shaderKeywords
		{
			get
			{
				return this.GetShaderKeywords();
			}
			set
			{
				this.SetShaderKeywords(value);
			}
		}

		// Token: 0x060011C4 RID: 4548 RVA: 0x0000AB80 File Offset: 0x00008D80
		public void SetFloat(string name, float val)
		{
			this.SetFloat(Shader.PropertyToID(name), val);
		}

		// Token: 0x060011C5 RID: 4549 RVA: 0x0000AB91 File Offset: 0x00008D91
		public void SetInt(string name, int val)
		{
			this.SetInt(Shader.PropertyToID(name), val);
		}

		// Token: 0x060011C6 RID: 4550 RVA: 0x0000ABA2 File Offset: 0x00008DA2
		public void SetVector(string name, Vector4 val)
		{
			this.SetVector(Shader.PropertyToID(name), val);
		}

		// Token: 0x060011C7 RID: 4551 RVA: 0x0000ABB3 File Offset: 0x00008DB3
		public void SetMatrix(string name, Matrix4x4 val)
		{
			this.SetMatrix(Shader.PropertyToID(name), val);
		}

		// Token: 0x060011C8 RID: 4552 RVA: 0x0000ABC4 File Offset: 0x00008DC4
		public void SetVectorArray(string name, Il2CppStructArray<Vector4> values)
		{
			this.SetVectorArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x060011C9 RID: 4553 RVA: 0x0000ABD5 File Offset: 0x00008DD5
		public void SetMatrixArray(string name, Il2CppStructArray<Matrix4x4> values)
		{
			this.SetMatrixArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x060011CA RID: 4554 RVA: 0x0000ABE6 File Offset: 0x00008DE6
		public void SetFloats(string name, Il2CppStructArray<float> values)
		{
			this.SetFloatArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x060011CB RID: 4555 RVA: 0x0000ABF7 File Offset: 0x00008DF7
		public void SetFloats(string name, params float[] values)
		{
			this.SetFloats(name, new Il2CppStructArray<float>(values));
		}

		// Token: 0x060011CC RID: 4556 RVA: 0x0000AC06 File Offset: 0x00008E06
		public void SetFloats(int nameID, Il2CppStructArray<float> values)
		{
			this.SetFloatArray(nameID, values);
		}

		// Token: 0x060011CD RID: 4557 RVA: 0x0000AC12 File Offset: 0x00008E12
		public void SetFloats(int nameID, params float[] values)
		{
			this.SetFloats(nameID, new Il2CppStructArray<float>(values));
		}

		// Token: 0x060011CE RID: 4558 RVA: 0x0000AC21 File Offset: 0x00008E21
		public void SetInts(string name, Il2CppStructArray<int> values)
		{
			this.SetIntArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x060011CF RID: 4559 RVA: 0x0000AC32 File Offset: 0x00008E32
		public void SetInts(string name, params int[] values)
		{
			this.SetInts(name, new Il2CppStructArray<int>(values));
		}

		// Token: 0x060011D0 RID: 4560 RVA: 0x0000AC41 File Offset: 0x00008E41
		public void SetInts(int nameID, Il2CppStructArray<int> values)
		{
			this.SetIntArray(nameID, values);
		}

		// Token: 0x060011D1 RID: 4561 RVA: 0x0000AC4D File Offset: 0x00008E4D
		public void SetInts(int nameID, params int[] values)
		{
			this.SetInts(nameID, new Il2CppStructArray<int>(values));
		}

		// Token: 0x060011D2 RID: 4562 RVA: 0x0000AC5C File Offset: 0x00008E5C
		public void SetBool(string name, bool val)
		{
			this.SetInt(Shader.PropertyToID(name), val ? 1 : 0);
		}

		// Token: 0x060011D3 RID: 4563 RVA: 0x0000AC73 File Offset: 0x00008E73
		public void SetBool(int nameID, bool val)
		{
			this.SetInt(nameID, val ? 1 : 0);
		}

		// Token: 0x060011D4 RID: 4564 RVA: 0x0000AC85 File Offset: 0x00008E85
		public void SetTexture(int kernelIndex, int nameID, Texture texture)
		{
			this.SetTexture(kernelIndex, nameID, texture, 0);
		}

		// Token: 0x060011D5 RID: 4565 RVA: 0x0000AC93 File Offset: 0x00008E93
		public void SetTexture(int kernelIndex, string name, Texture texture)
		{
			this.SetTexture(kernelIndex, Shader.PropertyToID(name), texture, 0);
		}

		// Token: 0x060011D6 RID: 4566 RVA: 0x0000ACA6 File Offset: 0x00008EA6
		public void SetTexture(int kernelIndex, string name, Texture texture, int mipLevel)
		{
			this.SetTexture(kernelIndex, Shader.PropertyToID(name), texture, mipLevel);
		}

		// Token: 0x060011D7 RID: 4567 RVA: 0x0000ACBA File Offset: 0x00008EBA
		public void SetTexture(int kernelIndex, int nameID, RenderTexture texture, int mipLevel, UnityEngine.Rendering.RenderTextureSubElement element)
		{
			this.SetRenderTexture(kernelIndex, nameID, texture, mipLevel, element);
		}

		// Token: 0x060011D8 RID: 4568 RVA: 0x0000ACCB File Offset: 0x00008ECB
		public void SetTexture(int kernelIndex, string name, RenderTexture texture, int mipLevel, UnityEngine.Rendering.RenderTextureSubElement element)
		{
			this.SetRenderTexture(kernelIndex, Shader.PropertyToID(name), texture, mipLevel, element);
		}

		// Token: 0x060011D9 RID: 4569 RVA: 0x0000ACE1 File Offset: 0x00008EE1
		public void SetTextureFromGlobal(int kernelIndex, string name, string globalTextureName)
		{
			this.SetTextureFromGlobal(kernelIndex, Shader.PropertyToID(name), Shader.PropertyToID(globalTextureName));
		}

		// Token: 0x060011DA RID: 4570 RVA: 0x0000ACF8 File Offset: 0x00008EF8
		public void SetBuffer(int kernelIndex, string name, ComputeBuffer buffer)
		{
			this.SetBuffer(kernelIndex, Shader.PropertyToID(name), buffer);
		}

		// Token: 0x060011DB RID: 4571 RVA: 0x0000AD0A File Offset: 0x00008F0A
		public void SetBuffer(int kernelIndex, string name, GraphicsBuffer buffer)
		{
			this.SetBuffer(kernelIndex, Shader.PropertyToID(name), buffer);
		}

		// Token: 0x060011DC RID: 4572 RVA: 0x0000AD1C File Offset: 0x00008F1C
		public void SetConstantBuffer(int nameID, ComputeBuffer buffer, int offset, int size)
		{
			this.SetConstantComputeBuffer(nameID, buffer, offset, size);
		}

		// Token: 0x060011DD RID: 4573 RVA: 0x0000AD2B File Offset: 0x00008F2B
		public void SetConstantBuffer(string name, ComputeBuffer buffer, int offset, int size)
		{
			this.SetConstantBuffer(Shader.PropertyToID(name), buffer, offset, size);
		}

		// Token: 0x060011DE RID: 4574 RVA: 0x0000AD3F File Offset: 0x00008F3F
		public void SetConstantBuffer(int nameID, GraphicsBuffer buffer, int offset, int size)
		{
			this.SetConstantGraphicsBuffer(nameID, buffer, offset, size);
		}

		// Token: 0x060011DF RID: 4575 RVA: 0x0000AD4E File Offset: 0x00008F4E
		public void SetConstantBuffer(string name, GraphicsBuffer buffer, int offset, int size)
		{
			this.SetConstantBuffer(Shader.PropertyToID(name), buffer, offset, size);
		}

		// Token: 0x060011E0 RID: 4576 RVA: 0x0000AD62 File Offset: 0x00008F62
		public void DispatchIndirect(int kernelIndex, ComputeBuffer argsBuffer, uint argsOffset)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060011E1 RID: 4577 RVA: 0x0000AD6F File Offset: 0x00008F6F
		public void DispatchIndirect(int kernelIndex, ComputeBuffer argsBuffer)
		{
			this.DispatchIndirect(kernelIndex, argsBuffer, 0U);
		}

		// Token: 0x060011E2 RID: 4578 RVA: 0x0000AD7C File Offset: 0x00008F7C
		public void DispatchIndirect(int kernelIndex, GraphicsBuffer argsBuffer, uint argsOffset)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060011E3 RID: 4579 RVA: 0x0000AD89 File Offset: 0x00008F89
		public void DispatchIndirect(int kernelIndex, GraphicsBuffer argsBuffer)
		{
			this.DispatchIndirect(kernelIndex, argsBuffer, 0U);
		}

		// Token: 0x060011E4 RID: 4580 RVA: 0x0000AD96 File Offset: 0x00008F96
		public void SetVector_Injected(int nameID, ref Vector4 val)
		{
			ComputeShader.SetVector_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, ref val);
		}

		// Token: 0x060011E5 RID: 4581 RVA: 0x0000ADAA File Offset: 0x00008FAA
		public void SetMatrix_Injected(int nameID, ref Matrix4x4 val)
		{
			ComputeShader.SetMatrix_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, ref val);
		}

		// Token: 0x04000D3D RID: 3389
		private static readonly IntPtr NativeMethodInfoPtr_FindKernel_Public_Int32_String_0;

		// Token: 0x04000D3E RID: 3390
		private static readonly ComputeShader.HasKernelDelegate HasKernelDelegateField;

		// Token: 0x04000D3F RID: 3391
		private static readonly ComputeShader.SetFloatDelegate SetFloatDelegateField;

		// Token: 0x04000D40 RID: 3392
		private static readonly ComputeShader.SetIntDelegate SetIntDelegateField;

		// Token: 0x04000D41 RID: 3393
		private static readonly ComputeShader.SetFloatArrayDelegate SetFloatArrayDelegateField;

		// Token: 0x04000D42 RID: 3394
		private static readonly ComputeShader.SetIntArrayDelegate SetIntArrayDelegateField;

		// Token: 0x04000D43 RID: 3395
		private static readonly ComputeShader.SetVectorArrayDelegate SetVectorArrayDelegateField;

		// Token: 0x04000D44 RID: 3396
		private static readonly ComputeShader.SetMatrixArrayDelegate SetMatrixArrayDelegateField;

		// Token: 0x04000D45 RID: 3397
		private static readonly ComputeShader.SetTextureDelegate SetTextureDelegateField;

		// Token: 0x04000D46 RID: 3398
		private static readonly ComputeShader.SetRenderTextureDelegate SetRenderTextureDelegateField;

		// Token: 0x04000D47 RID: 3399
		private static readonly ComputeShader.SetTextureFromGlobalDelegate SetTextureFromGlobalDelegateField;

		// Token: 0x04000D48 RID: 3400
		private static readonly ComputeShader.Internal_SetBufferDelegate Internal_SetBufferDelegateField;

		// Token: 0x04000D49 RID: 3401
		private static readonly ComputeShader.Internal_SetGraphicsBufferDelegate Internal_SetGraphicsBufferDelegateField;

		// Token: 0x04000D4A RID: 3402
		private static readonly ComputeShader.SetConstantComputeBufferDelegate SetConstantComputeBufferDelegateField;

		// Token: 0x04000D4B RID: 3403
		private static readonly ComputeShader.SetConstantGraphicsBufferDelegate SetConstantGraphicsBufferDelegateField;

		// Token: 0x04000D4C RID: 3404
		private static readonly ComputeShader.GetKernelThreadGroupSizesDelegate GetKernelThreadGroupSizesDelegateField;

		// Token: 0x04000D4D RID: 3405
		private static readonly ComputeShader.DispatchDelegate DispatchDelegateField;

		// Token: 0x04000D4E RID: 3406
		private static readonly ComputeShader.Internal_DispatchIndirectDelegate Internal_DispatchIndirectDelegateField;

		// Token: 0x04000D4F RID: 3407
		private static readonly ComputeShader.Internal_DispatchIndirectGraphicsBufferDelegate Internal_DispatchIndirectGraphicsBufferDelegateField;

		// Token: 0x04000D50 RID: 3408
		private static readonly ComputeShader.EnableKeywordDelegate EnableKeywordDelegateField;

		// Token: 0x04000D51 RID: 3409
		private static readonly ComputeShader.DisableKeywordDelegate DisableKeywordDelegateField;

		// Token: 0x04000D52 RID: 3410
		private static readonly ComputeShader.IsKeywordEnabledDelegate IsKeywordEnabledDelegateField;

		// Token: 0x04000D53 RID: 3411
		private static readonly ComputeShader.IsSupportedDelegate IsSupportedDelegateField;

		// Token: 0x04000D54 RID: 3412
		private static readonly ComputeShader.GetShaderKeywordsDelegate GetShaderKeywordsDelegateField;

		// Token: 0x04000D55 RID: 3413
		private static readonly ComputeShader.SetShaderKeywordsDelegate SetShaderKeywordsDelegateField;

		// Token: 0x04000D56 RID: 3414
		private static readonly ComputeShader.SetVector_InjectedDelegate SetVector_InjectedDelegateField;

		// Token: 0x04000D57 RID: 3415
		private static readonly ComputeShader.SetMatrix_InjectedDelegate SetMatrix_InjectedDelegateField;

		// Token: 0x020007B9 RID: 1977
		// (Invoke) Token: 0x06002D1E RID: 11550
		private delegate bool HasKernelDelegate(IntPtr @this, IntPtr name);

		// Token: 0x020007BA RID: 1978
		// (Invoke) Token: 0x06002D20 RID: 11552
		private delegate void SetFloatDelegate(IntPtr @this, int nameID, float val);

		// Token: 0x020007BB RID: 1979
		// (Invoke) Token: 0x06002D22 RID: 11554
		private delegate void SetIntDelegate(IntPtr @this, int nameID, int val);

		// Token: 0x020007BC RID: 1980
		// (Invoke) Token: 0x06002D24 RID: 11556
		private delegate void SetFloatArrayDelegate(IntPtr @this, int nameID, IntPtr values);

		// Token: 0x020007BD RID: 1981
		// (Invoke) Token: 0x06002D26 RID: 11558
		private delegate void SetIntArrayDelegate(IntPtr @this, int nameID, IntPtr values);

		// Token: 0x020007BE RID: 1982
		// (Invoke) Token: 0x06002D28 RID: 11560
		private delegate void SetVectorArrayDelegate(IntPtr @this, int nameID, IntPtr values);

		// Token: 0x020007BF RID: 1983
		// (Invoke) Token: 0x06002D2A RID: 11562
		private delegate void SetMatrixArrayDelegate(IntPtr @this, int nameID, IntPtr values);

		// Token: 0x020007C0 RID: 1984
		// (Invoke) Token: 0x06002D2C RID: 11564
		private delegate void SetTextureDelegate(IntPtr @this, int kernelIndex, int nameID, IntPtr texture, int mipLevel);

		// Token: 0x020007C1 RID: 1985
		// (Invoke) Token: 0x06002D2E RID: 11566
		private delegate void SetRenderTextureDelegate(IntPtr @this, int kernelIndex, int nameID, IntPtr texture, int mipLevel, UnityEngine.Rendering.RenderTextureSubElement element);

		// Token: 0x020007C2 RID: 1986
		// (Invoke) Token: 0x06002D30 RID: 11568
		private delegate void SetTextureFromGlobalDelegate(IntPtr @this, int kernelIndex, int nameID, int globalTextureNameID);

		// Token: 0x020007C3 RID: 1987
		// (Invoke) Token: 0x06002D32 RID: 11570
		private delegate void Internal_SetBufferDelegate(IntPtr @this, int kernelIndex, int nameID, IntPtr buffer);

		// Token: 0x020007C4 RID: 1988
		// (Invoke) Token: 0x06002D34 RID: 11572
		private delegate void Internal_SetGraphicsBufferDelegate(IntPtr @this, int kernelIndex, int nameID, IntPtr buffer);

		// Token: 0x020007C5 RID: 1989
		// (Invoke) Token: 0x06002D36 RID: 11574
		private delegate void SetConstantComputeBufferDelegate(IntPtr @this, int nameID, IntPtr buffer, int offset, int size);

		// Token: 0x020007C6 RID: 1990
		// (Invoke) Token: 0x06002D38 RID: 11576
		private delegate void SetConstantGraphicsBufferDelegate(IntPtr @this, int nameID, IntPtr buffer, int offset, int size);

		// Token: 0x020007C7 RID: 1991
		// (Invoke) Token: 0x06002D3A RID: 11578
		private delegate void GetKernelThreadGroupSizesDelegate(IntPtr @this, int kernelIndex, [Out] IntPtr x, [Out] IntPtr y, [Out] IntPtr z);

		// Token: 0x020007C8 RID: 1992
		// (Invoke) Token: 0x06002D3C RID: 11580
		private delegate void DispatchDelegate(IntPtr @this, int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ);

		// Token: 0x020007C9 RID: 1993
		// (Invoke) Token: 0x06002D3E RID: 11582
		private delegate void Internal_DispatchIndirectDelegate(IntPtr @this, int kernelIndex, IntPtr argsBuffer, uint argsOffset);

		// Token: 0x020007CA RID: 1994
		// (Invoke) Token: 0x06002D40 RID: 11584
		private delegate void Internal_DispatchIndirectGraphicsBufferDelegate(IntPtr @this, int kernelIndex, IntPtr argsBuffer, uint argsOffset);

		// Token: 0x020007CB RID: 1995
		// (Invoke) Token: 0x06002D42 RID: 11586
		private delegate void EnableKeywordDelegate(IntPtr @this, IntPtr keyword);

		// Token: 0x020007CC RID: 1996
		// (Invoke) Token: 0x06002D44 RID: 11588
		private delegate void DisableKeywordDelegate(IntPtr @this, IntPtr keyword);

		// Token: 0x020007CD RID: 1997
		// (Invoke) Token: 0x06002D46 RID: 11590
		private delegate bool IsKeywordEnabledDelegate(IntPtr @this, IntPtr keyword);

		// Token: 0x020007CE RID: 1998
		// (Invoke) Token: 0x06002D48 RID: 11592
		private delegate bool IsSupportedDelegate(IntPtr @this, int kernelIndex);

		// Token: 0x020007CF RID: 1999
		// (Invoke) Token: 0x06002D4A RID: 11594
		private delegate IntPtr GetShaderKeywordsDelegate(IntPtr @this);

		// Token: 0x020007D0 RID: 2000
		// (Invoke) Token: 0x06002D4C RID: 11596
		private delegate void SetShaderKeywordsDelegate(IntPtr @this, IntPtr names);

		// Token: 0x020007D1 RID: 2001
		// (Invoke) Token: 0x06002D4E RID: 11598
		private delegate void SetVector_InjectedDelegate(IntPtr @this, int nameID, IntPtr val);

		// Token: 0x020007D2 RID: 2002
		// (Invoke) Token: 0x06002D50 RID: 11600
		private delegate void SetMatrix_InjectedDelegate(IntPtr @this, int nameID, IntPtr val);
	}
}
