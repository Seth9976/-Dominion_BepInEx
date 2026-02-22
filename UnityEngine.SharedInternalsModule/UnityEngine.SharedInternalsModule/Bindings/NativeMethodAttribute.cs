using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Bindings
{
	// Token: 0x0200000D RID: 13
	public class NativeMethodAttribute : Attribute
	{
		// Token: 0x0600004B RID: 75 RVA: 0x00003210 File Offset: 0x00001410
		// Note: this type is marked as 'beforefieldinit'.
		static NativeMethodAttribute()
		{
			Il2CppClassPointerStore<NativeMethodAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.SharedInternalsModule.dll", "UnityEngine.Bindings", "NativeMethodAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeMethodAttribute>.NativeClassPtr);
			NativeMethodAttribute.NativeFieldInfoPtr__Name_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeMethodAttribute>.NativeClassPtr, "<Name>k__BackingField");
			NativeMethodAttribute.NativeFieldInfoPtr__IsThreadSafe_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeMethodAttribute>.NativeClassPtr, "<IsThreadSafe>k__BackingField");
			NativeMethodAttribute.NativeFieldInfoPtr__IsFreeFunction_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeMethodAttribute>.NativeClassPtr, "<IsFreeFunction>k__BackingField");
			NativeMethodAttribute.NativeFieldInfoPtr__ThrowsException_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeMethodAttribute>.NativeClassPtr, "<ThrowsException>k__BackingField");
			NativeMethodAttribute.NativeFieldInfoPtr__HasExplicitThis_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeMethodAttribute>.NativeClassPtr, "<HasExplicitThis>k__BackingField");
			NativeMethodAttribute.NativeMethodInfoPtr_set_Name_Public_Virtual_Final_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMethodAttribute>.NativeClassPtr, 100663317);
			NativeMethodAttribute.NativeMethodInfoPtr_set_IsThreadSafe_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMethodAttribute>.NativeClassPtr, 100663318);
			NativeMethodAttribute.NativeMethodInfoPtr_set_IsFreeFunction_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMethodAttribute>.NativeClassPtr, 100663319);
			NativeMethodAttribute.NativeMethodInfoPtr_set_ThrowsException_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMethodAttribute>.NativeClassPtr, 100663320);
			NativeMethodAttribute.NativeMethodInfoPtr_set_HasExplicitThis_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMethodAttribute>.NativeClassPtr, 100663321);
			NativeMethodAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMethodAttribute>.NativeClassPtr, 100663322);
			NativeMethodAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMethodAttribute>.NativeClassPtr, 100663323);
			NativeMethodAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMethodAttribute>.NativeClassPtr, 100663324);
			NativeMethodAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMethodAttribute>.NativeClassPtr, 100663325);
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000060 RID: 96 RVA: 0x000023C7 File Offset: 0x000005C7
		// (set) Token: 0x0600004C RID: 76 RVA: 0x00003358 File Offset: 0x00001558
		public unsafe virtual string Name
		{
			get
			{
				return this._Name_k__BackingField;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5326, RefRangeEnd = 5327, XrefRangeStart = 5326, XrefRangeEnd = 5327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodAttribute.NativeMethodInfoPtr_set_Name_Public_Virtual_Final_New_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000061 RID: 97 RVA: 0x000023CF File Offset: 0x000005CF
		// (set) Token: 0x0600004D RID: 77 RVA: 0x0000339C File Offset: 0x0000159C
		public unsafe virtual bool IsThreadSafe
		{
			get
			{
				return this._IsThreadSafe_k__BackingField;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodAttribute.NativeMethodInfoPtr_set_IsThreadSafe_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000062 RID: 98 RVA: 0x000023D7 File Offset: 0x000005D7
		// (set) Token: 0x0600004E RID: 78 RVA: 0x000033DC File Offset: 0x000015DC
		public unsafe virtual bool IsFreeFunction
		{
			get
			{
				return this._IsFreeFunction_k__BackingField;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodAttribute.NativeMethodInfoPtr_set_IsFreeFunction_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000063 RID: 99 RVA: 0x000023DF File Offset: 0x000005DF
		// (set) Token: 0x0600004F RID: 79 RVA: 0x0000341C File Offset: 0x0000161C
		public unsafe virtual bool ThrowsException
		{
			get
			{
				return this._ThrowsException_k__BackingField;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodAttribute.NativeMethodInfoPtr_set_ThrowsException_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000064 RID: 100 RVA: 0x000023E7 File Offset: 0x000005E7
		// (set) Token: 0x06000050 RID: 80 RVA: 0x0000345C File Offset: 0x0000165C
		public unsafe virtual bool HasExplicitThis
		{
			get
			{
				return this._HasExplicitThis_k__BackingField;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodAttribute.NativeMethodInfoPtr_set_HasExplicitThis_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000051 RID: 81 RVA: 0x0000349C File Offset: 0x0000169C
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeMethodAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeMethodAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x000034D8 File Offset: 0x000016D8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 58922, RefRangeEnd = 58928, XrefRangeStart = 58918, XrefRangeEnd = 58922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeMethodAttribute(string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeMethodAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00003524 File Offset: 0x00001724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58928, XrefRangeEnd = 58929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeMethodAttribute(string name, bool isFreeFunction)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeMethodAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isFreeFunction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00003580 File Offset: 0x00001780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58929, XrefRangeEnd = 58930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeMethodAttribute(string name, bool isFreeFunction, bool isThreadSafe)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeMethodAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isFreeFunction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isThreadSafe;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002333 File Offset: 0x00000533
		public NativeMethodAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000056 RID: 86 RVA: 0x000035E8 File Offset: 0x000017E8
		// (set) Token: 0x06000057 RID: 87 RVA: 0x0000233C File Offset: 0x0000053C
		public unsafe string _Name_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeMethodAttribute.NativeFieldInfoPtr__Name_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeMethodAttribute.NativeFieldInfoPtr__Name_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000058 RID: 88 RVA: 0x00003610 File Offset: 0x00001810
		// (set) Token: 0x06000059 RID: 89 RVA: 0x0000235B File Offset: 0x0000055B
		public unsafe bool _IsThreadSafe_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeMethodAttribute.NativeFieldInfoPtr__IsThreadSafe_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeMethodAttribute.NativeFieldInfoPtr__IsThreadSafe_k__BackingField)) = value;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600005A RID: 90 RVA: 0x00003638 File Offset: 0x00001838
		// (set) Token: 0x0600005B RID: 91 RVA: 0x00002376 File Offset: 0x00000576
		public unsafe bool _IsFreeFunction_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeMethodAttribute.NativeFieldInfoPtr__IsFreeFunction_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeMethodAttribute.NativeFieldInfoPtr__IsFreeFunction_k__BackingField)) = value;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600005C RID: 92 RVA: 0x00003660 File Offset: 0x00001860
		// (set) Token: 0x0600005D RID: 93 RVA: 0x00002391 File Offset: 0x00000591
		public unsafe bool _ThrowsException_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeMethodAttribute.NativeFieldInfoPtr__ThrowsException_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeMethodAttribute.NativeFieldInfoPtr__ThrowsException_k__BackingField)) = value;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600005E RID: 94 RVA: 0x00003688 File Offset: 0x00001888
		// (set) Token: 0x0600005F RID: 95 RVA: 0x000023AC File Offset: 0x000005AC
		public unsafe bool _HasExplicitThis_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeMethodAttribute.NativeFieldInfoPtr__HasExplicitThis_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeMethodAttribute.NativeFieldInfoPtr__HasExplicitThis_k__BackingField)) = value;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000065 RID: 101 RVA: 0x000023EF File Offset: 0x000005EF
		// (set) Token: 0x06000066 RID: 102 RVA: 0x000023FC File Offset: 0x000005FC
		public bool WritableSelf
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

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeFieldInfoPtr__Name_k__BackingField;

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeFieldInfoPtr__IsThreadSafe_k__BackingField;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeFieldInfoPtr__IsFreeFunction_k__BackingField;

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeFieldInfoPtr__ThrowsException_k__BackingField;

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeFieldInfoPtr__HasExplicitThis_k__BackingField;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeMethodInfoPtr_set_Name_Public_Virtual_Final_New_set_Void_String_0;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeMethodInfoPtr_set_IsThreadSafe_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeMethodInfoPtr_set_IsFreeFunction_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeMethodInfoPtr_set_ThrowsException_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeMethodInfoPtr_set_HasExplicitThis_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0;

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Boolean_0;
	}
}
