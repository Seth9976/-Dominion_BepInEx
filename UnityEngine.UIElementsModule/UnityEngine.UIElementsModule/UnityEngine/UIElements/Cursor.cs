using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000008 RID: 8
	public sealed class Cursor : ValueType
	{
		// Token: 0x06000031 RID: 49 RVA: 0x0000D19C File Offset: 0x0000B39C
		// Note: this type is marked as 'beforefieldinit'.
		static Cursor()
		{
			Il2CppClassPointerStore<Cursor>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "Cursor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Cursor>.NativeClassPtr);
			Cursor.NativeFieldInfoPtr__texture_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cursor>.NativeClassPtr, "<texture>k__BackingField");
			Cursor.NativeFieldInfoPtr__hotspot_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cursor>.NativeClassPtr, "<hotspot>k__BackingField");
			Cursor.NativeFieldInfoPtr__defaultCursorId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cursor>.NativeClassPtr, "<defaultCursorId>k__BackingField");
			Cursor.NativeMethodInfoPtr_get_texture_Public_get_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cursor>.NativeClassPtr, 100663306);
			Cursor.NativeMethodInfoPtr_get_hotspot_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cursor>.NativeClassPtr, 100663307);
			Cursor.NativeMethodInfoPtr_get_defaultCursorId_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cursor>.NativeClassPtr, 100663308);
			Cursor.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cursor>.NativeClassPtr, 100663309);
			Cursor.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Cursor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cursor>.NativeClassPtr, 100663310);
			Cursor.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cursor>.NativeClassPtr, 100663311);
			Cursor.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Cursor_Cursor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cursor>.NativeClassPtr, 100663312);
			Cursor.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cursor>.NativeClassPtr, 100663313);
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000032 RID: 50 RVA: 0x0000D2A8 File Offset: 0x0000B4A8
		// (set) Token: 0x06000042 RID: 66 RVA: 0x00002311 File Offset: 0x00000511
		public unsafe Texture2D texture
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cursor.NativeMethodInfoPtr_get_texture_Public_get_Texture2D_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
			}
			set
			{
				this._texture_k__BackingField = value;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000033 RID: 51 RVA: 0x0000D2EC File Offset: 0x0000B4EC
		// (set) Token: 0x06000043 RID: 67 RVA: 0x0000231A File Offset: 0x0000051A
		public unsafe Vector2 hotspot
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 88826, RefRangeEnd = 88828, XrefRangeStart = 88826, XrefRangeEnd = 88828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cursor.NativeMethodInfoPtr_get_hotspot_Public_get_Vector2_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this._hotspot_k__BackingField = value;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000034 RID: 52 RVA: 0x0000D330 File Offset: 0x0000B530
		// (set) Token: 0x06000044 RID: 68 RVA: 0x00002323 File Offset: 0x00000523
		public unsafe int defaultCursorId
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8799, RefRangeEnd = 8800, XrefRangeStart = 8799, XrefRangeEnd = 8800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cursor.NativeMethodInfoPtr_get_defaultCursorId_Internal_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this._defaultCursorId_k__BackingField = value;
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x0000D374 File Offset: 0x0000B574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91006, XrefRangeEnd = 91012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cursor.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x0000D3C8 File Offset: 0x0000B5C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91012, XrefRangeEnd = 91015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(Cursor other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cursor.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Cursor_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x0000D420 File Offset: 0x0000B620
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 91022, RefRangeEnd = 91024, XrefRangeStart = 91015, XrefRangeEnd = 91022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cursor.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x0000D464 File Offset: 0x0000B664
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 91027, RefRangeEnd = 91028, XrefRangeStart = 91024, XrefRangeEnd = 91027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(Cursor style1, Cursor style2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(style1));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(style2));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cursor.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Cursor_Cursor_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x0000D4C4 File Offset: 0x0000B6C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91028, XrefRangeEnd = 91034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cursor.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000022A1 File Offset: 0x000004A1
		public Cursor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600003B RID: 59 RVA: 0x000022AA File Offset: 0x000004AA
		public Cursor()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Cursor>.NativeClassPtr))
		{
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600003C RID: 60 RVA: 0x0000D500 File Offset: 0x0000B700
		// (set) Token: 0x0600003D RID: 61 RVA: 0x000022BC File Offset: 0x000004BC
		public unsafe Texture2D _texture_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cursor.NativeFieldInfoPtr__texture_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cursor.NativeFieldInfoPtr__texture_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600003E RID: 62 RVA: 0x0000D530 File Offset: 0x0000B730
		// (set) Token: 0x0600003F RID: 63 RVA: 0x000022DB File Offset: 0x000004DB
		public unsafe Vector2 _hotspot_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cursor.NativeFieldInfoPtr__hotspot_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cursor.NativeFieldInfoPtr__hotspot_k__BackingField)) = value;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000040 RID: 64 RVA: 0x0000D558 File Offset: 0x0000B758
		// (set) Token: 0x06000041 RID: 65 RVA: 0x000022F6 File Offset: 0x000004F6
		public unsafe int _defaultCursorId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cursor.NativeFieldInfoPtr__defaultCursorId_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cursor.NativeFieldInfoPtr__defaultCursorId_k__BackingField)) = value;
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x0000D580 File Offset: 0x0000B780
		public static bool operator !=(Cursor style1, Cursor style2)
		{
			return !(style1 == style2);
		}

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeFieldInfoPtr__texture_k__BackingField;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeFieldInfoPtr__hotspot_k__BackingField;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeFieldInfoPtr__defaultCursorId_k__BackingField;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeMethodInfoPtr_get_texture_Public_get_Texture2D_0;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeMethodInfoPtr_get_hotspot_Public_get_Vector2_0;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultCursorId_Internal_get_Int32_0;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Cursor_0;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Cursor_Cursor_0;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
