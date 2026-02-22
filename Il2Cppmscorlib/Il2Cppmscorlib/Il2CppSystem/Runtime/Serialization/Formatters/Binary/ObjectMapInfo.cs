using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000378 RID: 888
	public sealed class ObjectMapInfo : Object
	{
		// Token: 0x06003892 RID: 14482 RVA: 0x0010F134 File Offset: 0x0010D334
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectMapInfo()
		{
			Il2CppClassPointerStore<ObjectMapInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "ObjectMapInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectMapInfo>.NativeClassPtr);
			ObjectMapInfo.NativeFieldInfoPtr_objectId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectMapInfo>.NativeClassPtr, "objectId");
			ObjectMapInfo.NativeFieldInfoPtr_numMembers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectMapInfo>.NativeClassPtr, "numMembers");
			ObjectMapInfo.NativeFieldInfoPtr_memberNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectMapInfo>.NativeClassPtr, "memberNames");
			ObjectMapInfo.NativeFieldInfoPtr_memberTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectMapInfo>.NativeClassPtr, "memberTypes");
			ObjectMapInfo.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_Il2CppStringArray_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectMapInfo>.NativeClassPtr, 100671841);
			ObjectMapInfo.NativeMethodInfoPtr_isCompatible_Internal_Boolean_Int32_Il2CppStringArray_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectMapInfo>.NativeClassPtr, 100671842);
		}

		// Token: 0x06003893 RID: 14483 RVA: 0x0010F1DC File Offset: 0x0010D3DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 346135, RefRangeEnd = 346136, XrefRangeStart = 346135, XrefRangeEnd = 346135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectMapInfo(int objectId, int numMembers, Il2CppStringArray memberNames, Il2CppReferenceArray<Type> memberTypes)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectMapInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref objectId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numMembers;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberNames);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberTypes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectMapInfo.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_Il2CppStringArray_Il2CppReferenceArray_1_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003894 RID: 14484 RVA: 0x0010F258 File Offset: 0x0010D458
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 346137, RefRangeEnd = 346138, XrefRangeStart = 346136, XrefRangeEnd = 346137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool isCompatible(int numMembers, Il2CppStringArray memberNames, Il2CppReferenceArray<Type> memberTypes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref numMembers;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberNames);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberTypes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectMapInfo.NativeMethodInfoPtr_isCompatible_Internal_Boolean_Int32_Il2CppStringArray_Il2CppReferenceArray_1_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003895 RID: 14485 RVA: 0x00014B25 File Offset: 0x00012D25
		public ObjectMapInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000DDB RID: 3547
		// (get) Token: 0x06003896 RID: 14486 RVA: 0x0010F2C8 File Offset: 0x0010D4C8
		// (set) Token: 0x06003897 RID: 14487 RVA: 0x00014B2E File Offset: 0x00012D2E
		public unsafe int objectId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectMapInfo.NativeFieldInfoPtr_objectId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectMapInfo.NativeFieldInfoPtr_objectId)) = value;
			}
		}

		// Token: 0x17000DDC RID: 3548
		// (get) Token: 0x06003898 RID: 14488 RVA: 0x0010F2F0 File Offset: 0x0010D4F0
		// (set) Token: 0x06003899 RID: 14489 RVA: 0x00014B49 File Offset: 0x00012D49
		public unsafe int numMembers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectMapInfo.NativeFieldInfoPtr_numMembers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectMapInfo.NativeFieldInfoPtr_numMembers)) = value;
			}
		}

		// Token: 0x17000DDD RID: 3549
		// (get) Token: 0x0600389A RID: 14490 RVA: 0x0010F318 File Offset: 0x0010D518
		// (set) Token: 0x0600389B RID: 14491 RVA: 0x00014B64 File Offset: 0x00012D64
		public unsafe Il2CppStringArray memberNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectMapInfo.NativeFieldInfoPtr_memberNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectMapInfo.NativeFieldInfoPtr_memberNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DDE RID: 3550
		// (get) Token: 0x0600389C RID: 14492 RVA: 0x0010F348 File Offset: 0x0010D548
		// (set) Token: 0x0600389D RID: 14493 RVA: 0x00014B83 File Offset: 0x00012D83
		public unsafe Il2CppReferenceArray<Type> memberTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectMapInfo.NativeFieldInfoPtr_memberTypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectMapInfo.NativeFieldInfoPtr_memberTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002FAC RID: 12204
		private static readonly IntPtr NativeFieldInfoPtr_objectId;

		// Token: 0x04002FAD RID: 12205
		private static readonly IntPtr NativeFieldInfoPtr_numMembers;

		// Token: 0x04002FAE RID: 12206
		private static readonly IntPtr NativeFieldInfoPtr_memberNames;

		// Token: 0x04002FAF RID: 12207
		private static readonly IntPtr NativeFieldInfoPtr_memberTypes;

		// Token: 0x04002FB0 RID: 12208
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_Il2CppStringArray_Il2CppReferenceArray_1_Type_0;

		// Token: 0x04002FB1 RID: 12209
		private static readonly IntPtr NativeMethodInfoPtr_isCompatible_Internal_Boolean_Int32_Il2CppStringArray_Il2CppReferenceArray_1_Type_0;
	}
}
