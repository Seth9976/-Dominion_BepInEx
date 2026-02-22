using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x02000137 RID: 311
	[StructLayout(2)]
	public struct RenderTargetIdentifier
	{
		// Token: 0x0600178D RID: 6029 RVA: 0x000587F8 File Offset: 0x000569F8
		// Note: this type is marked as 'beforefieldinit'.
		static RenderTargetIdentifier()
		{
			Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "RenderTargetIdentifier");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr);
			RenderTargetIdentifier.NativeFieldInfoPtr_m_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, "m_Type");
			RenderTargetIdentifier.NativeFieldInfoPtr_m_NameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, "m_NameID");
			RenderTargetIdentifier.NativeFieldInfoPtr_m_InstanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, "m_InstanceID");
			RenderTargetIdentifier.NativeFieldInfoPtr_m_BufferPointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, "m_BufferPointer");
			RenderTargetIdentifier.NativeFieldInfoPtr_m_MipLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, "m_MipLevel");
			RenderTargetIdentifier.NativeFieldInfoPtr_m_CubeFace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, "m_CubeFace");
			RenderTargetIdentifier.NativeFieldInfoPtr_m_DepthSlice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, "m_DepthSlice");
			RenderTargetIdentifier.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, 100665084);
			RenderTargetIdentifier.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, 100665085);
			RenderTargetIdentifier.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, 100665086);
			RenderTargetIdentifier.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, 100665087);
		}

		// Token: 0x0600178E RID: 6030 RVA: 0x00058904 File Offset: 0x00056B04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82182, XrefRangeEnd = 82213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetIdentifier.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600178F RID: 6031 RVA: 0x00058930 File Offset: 0x00056B30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82213, XrefRangeEnd = 82216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetIdentifier.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001790 RID: 6032 RVA: 0x00058960 File Offset: 0x00056B60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 82217, RefRangeEnd = 82218, XrefRangeStart = 82216, XrefRangeEnd = 82217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(RenderTargetIdentifier rhs)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rhs;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetIdentifier.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RenderTargetIdentifier_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001791 RID: 6033 RVA: 0x000589A0 File Offset: 0x00056BA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82218, XrefRangeEnd = 82222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetIdentifier.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001792 RID: 6034 RVA: 0x0000D349 File Offset: 0x0000B549
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, ref this));
		}

		// Token: 0x06001793 RID: 6035 RVA: 0x000589E4 File Offset: 0x00056BE4
		public static implicit operator RenderTargetIdentifier(BuiltinRenderTextureType type)
		{
			return new RenderTargetIdentifier(type);
		}

		// Token: 0x06001794 RID: 6036 RVA: 0x000589FC File Offset: 0x00056BFC
		public static implicit operator RenderTargetIdentifier(string name)
		{
			return new RenderTargetIdentifier(name);
		}

		// Token: 0x06001795 RID: 6037 RVA: 0x00058A14 File Offset: 0x00056C14
		public static implicit operator RenderTargetIdentifier(int nameID)
		{
			return new RenderTargetIdentifier(nameID);
		}

		// Token: 0x06001796 RID: 6038 RVA: 0x00058A2C File Offset: 0x00056C2C
		public static implicit operator RenderTargetIdentifier(Texture tex)
		{
			return new RenderTargetIdentifier(tex);
		}

		// Token: 0x06001797 RID: 6039 RVA: 0x00058A44 File Offset: 0x00056C44
		public static bool operator ==(RenderTargetIdentifier lhs, RenderTargetIdentifier rhs)
		{
			return lhs.Equals(rhs);
		}

		// Token: 0x06001798 RID: 6040 RVA: 0x00058A60 File Offset: 0x00056C60
		public static bool operator !=(RenderTargetIdentifier lhs, RenderTargetIdentifier rhs)
		{
			return !lhs.Equals(rhs);
		}

		// Token: 0x0400116E RID: 4462
		private static readonly IntPtr NativeFieldInfoPtr_m_Type;

		// Token: 0x0400116F RID: 4463
		private static readonly IntPtr NativeFieldInfoPtr_m_NameID;

		// Token: 0x04001170 RID: 4464
		private static readonly IntPtr NativeFieldInfoPtr_m_InstanceID;

		// Token: 0x04001171 RID: 4465
		private static readonly IntPtr NativeFieldInfoPtr_m_BufferPointer;

		// Token: 0x04001172 RID: 4466
		private static readonly IntPtr NativeFieldInfoPtr_m_MipLevel;

		// Token: 0x04001173 RID: 4467
		private static readonly IntPtr NativeFieldInfoPtr_m_CubeFace;

		// Token: 0x04001174 RID: 4468
		private static readonly IntPtr NativeFieldInfoPtr_m_DepthSlice;

		// Token: 0x04001175 RID: 4469
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001176 RID: 4470
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001177 RID: 4471
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RenderTargetIdentifier_0;

		// Token: 0x04001178 RID: 4472
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001179 RID: 4473
		[FieldOffset(0)]
		public BuiltinRenderTextureType m_Type;

		// Token: 0x0400117A RID: 4474
		[FieldOffset(4)]
		public int m_NameID;

		// Token: 0x0400117B RID: 4475
		[FieldOffset(8)]
		public int m_InstanceID;

		// Token: 0x0400117C RID: 4476
		[FieldOffset(16)]
		public IntPtr m_BufferPointer;

		// Token: 0x0400117D RID: 4477
		[FieldOffset(24)]
		public int m_MipLevel;

		// Token: 0x0400117E RID: 4478
		[FieldOffset(28)]
		public CubemapFace m_CubeFace;

		// Token: 0x0400117F RID: 4479
		[FieldOffset(32)]
		public int m_DepthSlice;

		// Token: 0x04001180 RID: 4480
		public const int AllDepthSlices = -1;
	}
}
