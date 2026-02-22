using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x0200006A RID: 106
	public sealed class EditorBrowsableAttribute : Attribute
	{
		// Token: 0x0600078B RID: 1931 RVA: 0x0002C58C File Offset: 0x0002A78C
		// Note: this type is marked as 'beforefieldinit'.
		static EditorBrowsableAttribute()
		{
			Il2CppClassPointerStore<EditorBrowsableAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "EditorBrowsableAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EditorBrowsableAttribute>.NativeClassPtr);
			EditorBrowsableAttribute.NativeFieldInfoPtr_browsableState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorBrowsableAttribute>.NativeClassPtr, "browsableState");
			EditorBrowsableAttribute.NativeMethodInfoPtr__ctor_Public_Void_EditorBrowsableState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditorBrowsableAttribute>.NativeClassPtr, 100664278);
			EditorBrowsableAttribute.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditorBrowsableAttribute>.NativeClassPtr, 100664279);
			EditorBrowsableAttribute.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditorBrowsableAttribute>.NativeClassPtr, 100664280);
		}

		// Token: 0x0600078C RID: 1932 RVA: 0x0002C60C File Offset: 0x0002A80C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40950, XrefRangeEnd = 40951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EditorBrowsableAttribute(EditorBrowsableState state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EditorBrowsableAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EditorBrowsableAttribute.NativeMethodInfoPtr__ctor_Public_Void_EditorBrowsableState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600078D RID: 1933 RVA: 0x0002C654 File Offset: 0x0002A854
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40951, XrefRangeEnd = 40953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EditorBrowsableAttribute.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600078E RID: 1934 RVA: 0x0002C6A4 File Offset: 0x0002A8A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EditorBrowsableAttribute.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600078F RID: 1935 RVA: 0x00005061 File Offset: 0x00003261
		public EditorBrowsableAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x06000790 RID: 1936 RVA: 0x0002C6E0 File Offset: 0x0002A8E0
		// (set) Token: 0x06000791 RID: 1937 RVA: 0x0000506A File Offset: 0x0000326A
		public unsafe EditorBrowsableState browsableState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EditorBrowsableAttribute.NativeFieldInfoPtr_browsableState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EditorBrowsableAttribute.NativeFieldInfoPtr_browsableState)) = value;
			}
		}

		// Token: 0x0400058C RID: 1420
		private static readonly IntPtr NativeFieldInfoPtr_browsableState;

		// Token: 0x0400058D RID: 1421
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EditorBrowsableState_0;

		// Token: 0x0400058E RID: 1422
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400058F RID: 1423
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}
