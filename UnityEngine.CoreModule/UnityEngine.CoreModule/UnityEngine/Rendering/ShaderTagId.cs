using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x02000145 RID: 325
	[StructLayout(2)]
	public struct ShaderTagId
	{
		// Token: 0x060018A4 RID: 6308 RVA: 0x0005AF18 File Offset: 0x00059118
		// Note: this type is marked as 'beforefieldinit'.
		static ShaderTagId()
		{
			Il2CppClassPointerStore<ShaderTagId>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "ShaderTagId");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderTagId>.NativeClassPtr);
			ShaderTagId.NativeFieldInfoPtr_none = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderTagId>.NativeClassPtr, "none");
			ShaderTagId.NativeFieldInfoPtr_m_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderTagId>.NativeClassPtr, "m_Id");
			ShaderTagId.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderTagId>.NativeClassPtr, 100665147);
			ShaderTagId.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderTagId>.NativeClassPtr, 100665148);
			ShaderTagId.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ShaderTagId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderTagId>.NativeClassPtr, 100665149);
			ShaderTagId.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderTagId>.NativeClassPtr, 100665150);
		}

		// Token: 0x060018A5 RID: 6309 RVA: 0x0005AFC0 File Offset: 0x000591C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82527, XrefRangeEnd = 82529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShaderTagId(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderTagId.NativeMethodInfoPtr__ctor_Public_Void_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018A6 RID: 6310 RVA: 0x0005AFF8 File Offset: 0x000591F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82529, XrefRangeEnd = 82532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderTagId.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018A7 RID: 6311 RVA: 0x0005B03C File Offset: 0x0005923C
		[CallerCount(0)]
		public unsafe bool Equals(ShaderTagId other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderTagId.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ShaderTagId_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018A8 RID: 6312 RVA: 0x0005B07C File Offset: 0x0005927C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82532, XrefRangeEnd = 82533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderTagId.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018A9 RID: 6313 RVA: 0x0000DCDF File Offset: 0x0000BEDF
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShaderTagId>.NativeClassPtr, ref this));
		}

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x060018AA RID: 6314 RVA: 0x0005B0AC File Offset: 0x000592AC
		// (set) Token: 0x060018AB RID: 6315 RVA: 0x0000DCF1 File Offset: 0x0000BEF1
		public unsafe static ShaderTagId none
		{
			get
			{
				ShaderTagId shaderTagId;
				IL2CPP.il2cpp_field_static_get_value(ShaderTagId.NativeFieldInfoPtr_none, (void*)(&shaderTagId));
				return shaderTagId;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderTagId.NativeFieldInfoPtr_none, (void*)(&value));
			}
		}

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x060018AC RID: 6316 RVA: 0x0005B0C8 File Offset: 0x000592C8
		// (set) Token: 0x060018AD RID: 6317 RVA: 0x0000DCFF File Offset: 0x0000BEFF
		public int id
		{
			get
			{
				return this.m_Id;
			}
			set
			{
				this.m_Id = value;
			}
		}

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x060018AE RID: 6318 RVA: 0x0005B0E0 File Offset: 0x000592E0
		public string name
		{
			get
			{
				return Shader.IDToTag(this.id);
			}
		}

		// Token: 0x060018AF RID: 6319 RVA: 0x0005B100 File Offset: 0x00059300
		public static bool operator ==(ShaderTagId tag1, ShaderTagId tag2)
		{
			return tag1.Equals(tag2);
		}

		// Token: 0x060018B0 RID: 6320 RVA: 0x0005B11C File Offset: 0x0005931C
		public static bool operator !=(ShaderTagId tag1, ShaderTagId tag2)
		{
			return !(tag1 == tag2);
		}

		// Token: 0x060018B1 RID: 6321 RVA: 0x0005B138 File Offset: 0x00059338
		public static explicit operator ShaderTagId(string name)
		{
			return new ShaderTagId(name);
		}

		// Token: 0x060018B2 RID: 6322 RVA: 0x0005B150 File Offset: 0x00059350
		public static explicit operator string(ShaderTagId tagId)
		{
			return tagId.name;
		}

		// Token: 0x0400123B RID: 4667
		private static readonly IntPtr NativeFieldInfoPtr_none;

		// Token: 0x0400123C RID: 4668
		private static readonly IntPtr NativeFieldInfoPtr_m_Id;

		// Token: 0x0400123D RID: 4669
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x0400123E RID: 4670
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400123F RID: 4671
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ShaderTagId_0;

		// Token: 0x04001240 RID: 4672
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001241 RID: 4673
		[FieldOffset(0)]
		public int m_Id;
	}
}
