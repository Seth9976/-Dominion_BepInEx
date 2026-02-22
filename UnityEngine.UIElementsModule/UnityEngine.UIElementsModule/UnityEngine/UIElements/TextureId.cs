using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020000A9 RID: 169
	[StructLayout(2)]
	public struct TextureId
	{
		// Token: 0x060008B9 RID: 2233 RVA: 0x00028CD8 File Offset: 0x00026ED8
		// Note: this type is marked as 'beforefieldinit'.
		static TextureId()
		{
			Il2CppClassPointerStore<TextureId>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "TextureId");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextureId>.NativeClassPtr);
			TextureId.NativeFieldInfoPtr_m_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureId>.NativeClassPtr, "m_Index");
			TextureId.NativeFieldInfoPtr_invalid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureId>.NativeClassPtr, "invalid");
			TextureId.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureId>.NativeClassPtr, 100664145);
			TextureId.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureId>.NativeClassPtr, 100664146);
			TextureId.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureId>.NativeClassPtr, 100664147);
			TextureId.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_TextureId_TextureId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureId>.NativeClassPtr, 100664148);
		}

		// Token: 0x060008BA RID: 2234 RVA: 0x00028D80 File Offset: 0x00026F80
		[CallerCount(0)]
		public unsafe TextureId(int index)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureId.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008BB RID: 2235 RVA: 0x00028DB4 File Offset: 0x00026FB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96600, XrefRangeEnd = 96605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureId.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008BC RID: 2236 RVA: 0x00028DF8 File Offset: 0x00026FF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96605, XrefRangeEnd = 96606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureId.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008BD RID: 2237 RVA: 0x00028E28 File Offset: 0x00027028
		[CallerCount(0)]
		public unsafe static bool operator ==(TextureId left, TextureId right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref left;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureId.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_TextureId_TextureId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008BE RID: 2238 RVA: 0x00005AFE File Offset: 0x00003CFE
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextureId>.NativeClassPtr, ref this));
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x060008BF RID: 2239 RVA: 0x00028E74 File Offset: 0x00027074
		// (set) Token: 0x060008C0 RID: 2240 RVA: 0x00005B10 File Offset: 0x00003D10
		public unsafe static TextureId invalid
		{
			get
			{
				TextureId textureId;
				IL2CPP.il2cpp_field_static_get_value(TextureId.NativeFieldInfoPtr_invalid, (void*)(&textureId));
				return textureId;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextureId.NativeFieldInfoPtr_invalid, (void*)(&value));
			}
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x060008C1 RID: 2241 RVA: 0x00005B1E File Offset: 0x00003D1E
		public int index
		{
			get
			{
				return this.m_Index - 1;
			}
		}

		// Token: 0x060008C2 RID: 2242 RVA: 0x00028E90 File Offset: 0x00027090
		public float ConvertToGpu()
		{
			return (float)this.index;
		}

		// Token: 0x060008C3 RID: 2243 RVA: 0x00028EAC File Offset: 0x000270AC
		public bool Equals(TextureId other)
		{
			return this.m_Index == other.m_Index;
		}

		// Token: 0x060008C4 RID: 2244 RVA: 0x00028ECC File Offset: 0x000270CC
		public static bool operator !=(TextureId left, TextureId right)
		{
			return !(left == right);
		}

		// Token: 0x040004F2 RID: 1266
		private static readonly IntPtr NativeFieldInfoPtr_m_Index;

		// Token: 0x040004F3 RID: 1267
		private static readonly IntPtr NativeFieldInfoPtr_invalid;

		// Token: 0x040004F4 RID: 1268
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040004F5 RID: 1269
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040004F6 RID: 1270
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040004F7 RID: 1271
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_TextureId_TextureId_0;

		// Token: 0x040004F8 RID: 1272
		[FieldOffset(0)]
		public readonly int m_Index;
	}
}
