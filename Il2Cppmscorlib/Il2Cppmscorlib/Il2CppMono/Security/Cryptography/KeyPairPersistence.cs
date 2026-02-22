using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Security.Cryptography;

namespace Il2CppMono.Security.Cryptography
{
	// Token: 0x0200002B RID: 43
	public class KeyPairPersistence : Object
	{
		// Token: 0x060002BF RID: 703 RVA: 0x0002CD78 File Offset: 0x0002AF78
		// Note: this type is marked as 'beforefieldinit'.
		static KeyPairPersistence()
		{
			Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono.Security.Cryptography", "KeyPairPersistence");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr);
			KeyPairPersistence.NativeFieldInfoPtr__userPathExists = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, "_userPathExists");
			KeyPairPersistence.NativeFieldInfoPtr__userPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, "_userPath");
			KeyPairPersistence.NativeFieldInfoPtr__machinePathExists = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, "_machinePathExists");
			KeyPairPersistence.NativeFieldInfoPtr__machinePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, "_machinePath");
			KeyPairPersistence.NativeFieldInfoPtr__params = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, "_params");
			KeyPairPersistence.NativeFieldInfoPtr__keyvalue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, "_keyvalue");
			KeyPairPersistence.NativeFieldInfoPtr__filename = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, "_filename");
			KeyPairPersistence.NativeFieldInfoPtr__container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, "_container");
			KeyPairPersistence.NativeFieldInfoPtr_lockobj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, "lockobj");
			KeyPairPersistence.NativeMethodInfoPtr__ctor_Public_Void_CspParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, 100663658);
			KeyPairPersistence.NativeMethodInfoPtr__ctor_Public_Void_CspParameters_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, 100663659);
			KeyPairPersistence.NativeMethodInfoPtr_get_Filename_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, 100663660);
			KeyPairPersistence.NativeMethodInfoPtr_get_KeyValue_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, 100663661);
			KeyPairPersistence.NativeMethodInfoPtr_set_KeyValue_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, 100663662);
			KeyPairPersistence.NativeMethodInfoPtr_Load_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, 100663663);
			KeyPairPersistence.NativeMethodInfoPtr_Save_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, 100663664);
			KeyPairPersistence.NativeMethodInfoPtr_Remove_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, 100663665);
			KeyPairPersistence.NativeMethodInfoPtr_get_UserPath_Private_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, 100663666);
			KeyPairPersistence.NativeMethodInfoPtr_get_MachinePath_Private_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, 100663667);
			KeyPairPersistence.NativeMethodInfoPtr__CanSecure_Internal_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, 100663668);
			KeyPairPersistence.NativeMethodInfoPtr__ProtectUser_Internal_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, 100663669);
			KeyPairPersistence.NativeMethodInfoPtr__ProtectMachine_Internal_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, 100663670);
			KeyPairPersistence.NativeMethodInfoPtr__IsUserProtected_Internal_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, 100663671);
			KeyPairPersistence.NativeMethodInfoPtr__IsMachineProtected_Internal_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, 100663672);
			KeyPairPersistence.NativeMethodInfoPtr_CanSecure_Private_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, 100663673);
			KeyPairPersistence.NativeMethodInfoPtr_ProtectUser_Private_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, 100663674);
			KeyPairPersistence.NativeMethodInfoPtr_ProtectMachine_Private_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, 100663675);
			KeyPairPersistence.NativeMethodInfoPtr_IsUserProtected_Private_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, 100663676);
			KeyPairPersistence.NativeMethodInfoPtr_IsMachineProtected_Private_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, 100663677);
			KeyPairPersistence.NativeMethodInfoPtr_get_CanChange_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, 100663678);
			KeyPairPersistence.NativeMethodInfoPtr_get_UseDefaultKeyContainer_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, 100663679);
			KeyPairPersistence.NativeMethodInfoPtr_get_UseMachineKeyStore_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, 100663680);
			KeyPairPersistence.NativeMethodInfoPtr_get_ContainerName_Private_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, 100663681);
			KeyPairPersistence.NativeMethodInfoPtr_Copy_Private_CspParameters_CspParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, 100663682);
			KeyPairPersistence.NativeMethodInfoPtr_FromXml_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, 100663683);
			KeyPairPersistence.NativeMethodInfoPtr_ToXml_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, 100663684);
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x0002D078 File Offset: 0x0002B278
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 262512, RefRangeEnd = 262517, XrefRangeStart = 262506, XrefRangeEnd = 262512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KeyPairPersistence(CspParameters parameters)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parameters);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyPairPersistence.NativeMethodInfoPtr__ctor_Public_Void_CspParameters_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x0002D0C4 File Offset: 0x0002B2C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262517, XrefRangeEnd = 262523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KeyPairPersistence(CspParameters parameters, string keyPair)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parameters);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(keyPair);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyPairPersistence.NativeMethodInfoPtr__ctor_Public_Void_CspParameters_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x060002C2 RID: 706 RVA: 0x0002D124 File Offset: 0x0002B324
		public unsafe string Filename
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 262544, RefRangeEnd = 262550, XrefRangeStart = 262523, XrefRangeEnd = 262544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyPairPersistence.NativeMethodInfoPtr_get_Filename_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x060002C3 RID: 707 RVA: 0x0002D15C File Offset: 0x0002B35C
		// (set) Token: 0x060002C4 RID: 708 RVA: 0x0002D194 File Offset: 0x0002B394
		public unsafe string KeyValue
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyPairPersistence.NativeMethodInfoPtr_get_KeyValue_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 262550, RefRangeEnd = 262552, XrefRangeStart = 262550, XrefRangeEnd = 262550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyPairPersistence.NativeMethodInfoPtr_set_KeyValue_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x0002D1D8 File Offset: 0x0002B3D8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 262571, RefRangeEnd = 262574, XrefRangeStart = 262552, XrefRangeEnd = 262571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Load()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyPairPersistence.NativeMethodInfoPtr_Load_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x0002D214 File Offset: 0x0002B414
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 262598, RefRangeEnd = 262600, XrefRangeStart = 262574, XrefRangeEnd = 262598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Save()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyPairPersistence.NativeMethodInfoPtr_Save_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x0002D248 File Offset: 0x0002B448
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 262602, RefRangeEnd = 262604, XrefRangeStart = 262600, XrefRangeEnd = 262602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Remove()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyPairPersistence.NativeMethodInfoPtr_Remove_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060002C8 RID: 712 RVA: 0x0002D27C File Offset: 0x0002B47C
		public unsafe static string UserPath
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 262657, RefRangeEnd = 262658, XrefRangeStart = 262604, XrefRangeEnd = 262657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyPairPersistence.NativeMethodInfoPtr_get_UserPath_Private_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060002C9 RID: 713 RVA: 0x0002D2A8 File Offset: 0x0002B4A8
		public unsafe static string MachinePath
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262658, XrefRangeEnd = 262711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyPairPersistence.NativeMethodInfoPtr_get_MachinePath_Private_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060002CA RID: 714 RVA: 0x0002D2D4 File Offset: 0x0002B4D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 262712, RefRangeEnd = 262714, XrefRangeStart = 262711, XrefRangeEnd = 262712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _CanSecure(string root)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(root);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyPairPersistence.NativeMethodInfoPtr__CanSecure_Internal_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002CB RID: 715 RVA: 0x0002D318 File Offset: 0x0002B518
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 262712, RefRangeEnd = 262714, XrefRangeStart = 262712, XrefRangeEnd = 262714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _ProtectUser(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyPairPersistence.NativeMethodInfoPtr__ProtectUser_Internal_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002CC RID: 716 RVA: 0x0002D35C File Offset: 0x0002B55C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 262712, RefRangeEnd = 262714, XrefRangeStart = 262712, XrefRangeEnd = 262714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _ProtectMachine(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyPairPersistence.NativeMethodInfoPtr__ProtectMachine_Internal_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002CD RID: 717 RVA: 0x0002D3A0 File Offset: 0x0002B5A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 262712, RefRangeEnd = 262714, XrefRangeStart = 262712, XrefRangeEnd = 262714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _IsUserProtected(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyPairPersistence.NativeMethodInfoPtr__IsUserProtected_Internal_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002CE RID: 718 RVA: 0x0002D3E4 File Offset: 0x0002B5E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 262712, RefRangeEnd = 262714, XrefRangeStart = 262712, XrefRangeEnd = 262714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _IsMachineProtected(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyPairPersistence.NativeMethodInfoPtr__IsMachineProtected_Internal_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002CF RID: 719 RVA: 0x0002D428 File Offset: 0x0002B628
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 262723, RefRangeEnd = 262727, XrefRangeStart = 262714, XrefRangeEnd = 262723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CanSecure(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyPairPersistence.NativeMethodInfoPtr_CanSecure_Private_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x0002D46C File Offset: 0x0002B66C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 262731, RefRangeEnd = 262733, XrefRangeStart = 262727, XrefRangeEnd = 262731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ProtectUser(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyPairPersistence.NativeMethodInfoPtr_ProtectUser_Private_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x0002D4B0 File Offset: 0x0002B6B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 262737, RefRangeEnd = 262739, XrefRangeStart = 262733, XrefRangeEnd = 262737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ProtectMachine(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyPairPersistence.NativeMethodInfoPtr_ProtectMachine_Private_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x0002D4F4 File Offset: 0x0002B6F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 262743, RefRangeEnd = 262745, XrefRangeStart = 262739, XrefRangeEnd = 262743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsUserProtected(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyPairPersistence.NativeMethodInfoPtr_IsUserProtected_Private_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x0002D538 File Offset: 0x0002B738
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 262749, RefRangeEnd = 262751, XrefRangeStart = 262745, XrefRangeEnd = 262749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsMachineProtected(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyPairPersistence.NativeMethodInfoPtr_IsMachineProtected_Private_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060002D4 RID: 724 RVA: 0x0002D57C File Offset: 0x0002B77C
		public unsafe bool CanChange
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 45465, RefRangeEnd = 45471, XrefRangeStart = 45465, XrefRangeEnd = 45471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyPairPersistence.NativeMethodInfoPtr_get_CanChange_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060002D5 RID: 725 RVA: 0x0002D5B8 File Offset: 0x0002B7B8
		public unsafe bool UseDefaultKeyContainer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyPairPersistence.NativeMethodInfoPtr_get_UseDefaultKeyContainer_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060002D6 RID: 726 RVA: 0x0002D5F4 File Offset: 0x0002B7F4
		public unsafe bool UseMachineKeyStore
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyPairPersistence.NativeMethodInfoPtr_get_UseMachineKeyStore_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x060002D7 RID: 727 RVA: 0x0002D630 File Offset: 0x0002B830
		public unsafe string ContainerName
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 262762, RefRangeEnd = 262764, XrefRangeStart = 262751, XrefRangeEnd = 262762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyPairPersistence.NativeMethodInfoPtr_get_ContainerName_Private_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x0002D668 File Offset: 0x0002B868
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262764, XrefRangeEnd = 262769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CspParameters Copy(CspParameters p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyPairPersistence.NativeMethodInfoPtr_Copy_Private_CspParameters_CspParameters_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CspParameters>(intPtr3) : null;
			}
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x0002D6B8 File Offset: 0x0002B8B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262769, XrefRangeEnd = 262780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FromXml(string xml)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(xml);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyPairPersistence.NativeMethodInfoPtr_FromXml_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002DA RID: 730 RVA: 0x0002D6FC File Offset: 0x0002B8FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 262820, RefRangeEnd = 262821, XrefRangeStart = 262780, XrefRangeEnd = 262820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToXml()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyPairPersistence.NativeMethodInfoPtr_ToXml_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060002DB RID: 731 RVA: 0x00003284 File Offset: 0x00001484
		public KeyPairPersistence(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060002DC RID: 732 RVA: 0x0002D734 File Offset: 0x0002B934
		// (set) Token: 0x060002DD RID: 733 RVA: 0x0000328D File Offset: 0x0000148D
		public unsafe static bool _userPathExists
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(KeyPairPersistence.NativeFieldInfoPtr__userPathExists, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(KeyPairPersistence.NativeFieldInfoPtr__userPathExists, (void*)(&value));
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060002DE RID: 734 RVA: 0x0002D750 File Offset: 0x0002B950
		// (set) Token: 0x060002DF RID: 735 RVA: 0x0000329B File Offset: 0x0000149B
		public unsafe static string _userPath
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(KeyPairPersistence.NativeFieldInfoPtr__userPath, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(KeyPairPersistence.NativeFieldInfoPtr__userPath, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x060002E0 RID: 736 RVA: 0x0002D770 File Offset: 0x0002B970
		// (set) Token: 0x060002E1 RID: 737 RVA: 0x000032AD File Offset: 0x000014AD
		public unsafe static bool _machinePathExists
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(KeyPairPersistence.NativeFieldInfoPtr__machinePathExists, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(KeyPairPersistence.NativeFieldInfoPtr__machinePathExists, (void*)(&value));
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060002E2 RID: 738 RVA: 0x0002D78C File Offset: 0x0002B98C
		// (set) Token: 0x060002E3 RID: 739 RVA: 0x000032BB File Offset: 0x000014BB
		public unsafe static string _machinePath
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(KeyPairPersistence.NativeFieldInfoPtr__machinePath, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(KeyPairPersistence.NativeFieldInfoPtr__machinePath, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060002E4 RID: 740 RVA: 0x0002D7AC File Offset: 0x0002B9AC
		// (set) Token: 0x060002E5 RID: 741 RVA: 0x000032CD File Offset: 0x000014CD
		public unsafe CspParameters _params
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyPairPersistence.NativeFieldInfoPtr__params);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CspParameters>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyPairPersistence.NativeFieldInfoPtr__params), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060002E6 RID: 742 RVA: 0x0002D7DC File Offset: 0x0002B9DC
		// (set) Token: 0x060002E7 RID: 743 RVA: 0x000032EC File Offset: 0x000014EC
		public unsafe string _keyvalue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyPairPersistence.NativeFieldInfoPtr__keyvalue);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyPairPersistence.NativeFieldInfoPtr__keyvalue), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060002E8 RID: 744 RVA: 0x0002D804 File Offset: 0x0002BA04
		// (set) Token: 0x060002E9 RID: 745 RVA: 0x0000330B File Offset: 0x0000150B
		public unsafe string _filename
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyPairPersistence.NativeFieldInfoPtr__filename);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyPairPersistence.NativeFieldInfoPtr__filename), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x060002EA RID: 746 RVA: 0x0002D82C File Offset: 0x0002BA2C
		// (set) Token: 0x060002EB RID: 747 RVA: 0x0000332A File Offset: 0x0000152A
		public unsafe string _container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyPairPersistence.NativeFieldInfoPtr__container);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyPairPersistence.NativeFieldInfoPtr__container), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x060002EC RID: 748 RVA: 0x0002D854 File Offset: 0x0002BA54
		// (set) Token: 0x060002ED RID: 749 RVA: 0x00003349 File Offset: 0x00001549
		public unsafe static Object lockobj
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(KeyPairPersistence.NativeFieldInfoPtr_lockobj, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(KeyPairPersistence.NativeFieldInfoPtr_lockobj, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001EE RID: 494
		private static readonly IntPtr NativeFieldInfoPtr__userPathExists;

		// Token: 0x040001EF RID: 495
		private static readonly IntPtr NativeFieldInfoPtr__userPath;

		// Token: 0x040001F0 RID: 496
		private static readonly IntPtr NativeFieldInfoPtr__machinePathExists;

		// Token: 0x040001F1 RID: 497
		private static readonly IntPtr NativeFieldInfoPtr__machinePath;

		// Token: 0x040001F2 RID: 498
		private static readonly IntPtr NativeFieldInfoPtr__params;

		// Token: 0x040001F3 RID: 499
		private static readonly IntPtr NativeFieldInfoPtr__keyvalue;

		// Token: 0x040001F4 RID: 500
		private static readonly IntPtr NativeFieldInfoPtr__filename;

		// Token: 0x040001F5 RID: 501
		private static readonly IntPtr NativeFieldInfoPtr__container;

		// Token: 0x040001F6 RID: 502
		private static readonly IntPtr NativeFieldInfoPtr_lockobj;

		// Token: 0x040001F7 RID: 503
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_CspParameters_0;

		// Token: 0x040001F8 RID: 504
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_CspParameters_String_0;

		// Token: 0x040001F9 RID: 505
		private static readonly IntPtr NativeMethodInfoPtr_get_Filename_Public_get_String_0;

		// Token: 0x040001FA RID: 506
		private static readonly IntPtr NativeMethodInfoPtr_get_KeyValue_Public_get_String_0;

		// Token: 0x040001FB RID: 507
		private static readonly IntPtr NativeMethodInfoPtr_set_KeyValue_Public_set_Void_String_0;

		// Token: 0x040001FC RID: 508
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Boolean_0;

		// Token: 0x040001FD RID: 509
		private static readonly IntPtr NativeMethodInfoPtr_Save_Public_Void_0;

		// Token: 0x040001FE RID: 510
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Void_0;

		// Token: 0x040001FF RID: 511
		private static readonly IntPtr NativeMethodInfoPtr_get_UserPath_Private_Static_get_String_0;

		// Token: 0x04000200 RID: 512
		private static readonly IntPtr NativeMethodInfoPtr_get_MachinePath_Private_Static_get_String_0;

		// Token: 0x04000201 RID: 513
		private static readonly IntPtr NativeMethodInfoPtr__CanSecure_Internal_Static_Boolean_String_0;

		// Token: 0x04000202 RID: 514
		private static readonly IntPtr NativeMethodInfoPtr__ProtectUser_Internal_Static_Boolean_String_0;

		// Token: 0x04000203 RID: 515
		private static readonly IntPtr NativeMethodInfoPtr__ProtectMachine_Internal_Static_Boolean_String_0;

		// Token: 0x04000204 RID: 516
		private static readonly IntPtr NativeMethodInfoPtr__IsUserProtected_Internal_Static_Boolean_String_0;

		// Token: 0x04000205 RID: 517
		private static readonly IntPtr NativeMethodInfoPtr__IsMachineProtected_Internal_Static_Boolean_String_0;

		// Token: 0x04000206 RID: 518
		private static readonly IntPtr NativeMethodInfoPtr_CanSecure_Private_Static_Boolean_String_0;

		// Token: 0x04000207 RID: 519
		private static readonly IntPtr NativeMethodInfoPtr_ProtectUser_Private_Static_Boolean_String_0;

		// Token: 0x04000208 RID: 520
		private static readonly IntPtr NativeMethodInfoPtr_ProtectMachine_Private_Static_Boolean_String_0;

		// Token: 0x04000209 RID: 521
		private static readonly IntPtr NativeMethodInfoPtr_IsUserProtected_Private_Static_Boolean_String_0;

		// Token: 0x0400020A RID: 522
		private static readonly IntPtr NativeMethodInfoPtr_IsMachineProtected_Private_Static_Boolean_String_0;

		// Token: 0x0400020B RID: 523
		private static readonly IntPtr NativeMethodInfoPtr_get_CanChange_Private_get_Boolean_0;

		// Token: 0x0400020C RID: 524
		private static readonly IntPtr NativeMethodInfoPtr_get_UseDefaultKeyContainer_Private_get_Boolean_0;

		// Token: 0x0400020D RID: 525
		private static readonly IntPtr NativeMethodInfoPtr_get_UseMachineKeyStore_Private_get_Boolean_0;

		// Token: 0x0400020E RID: 526
		private static readonly IntPtr NativeMethodInfoPtr_get_ContainerName_Private_get_String_0;

		// Token: 0x0400020F RID: 527
		private static readonly IntPtr NativeMethodInfoPtr_Copy_Private_CspParameters_CspParameters_0;

		// Token: 0x04000210 RID: 528
		private static readonly IntPtr NativeMethodInfoPtr_FromXml_Private_Void_String_0;

		// Token: 0x04000211 RID: 529
		private static readonly IntPtr NativeMethodInfoPtr_ToXml_Private_String_0;
	}
}
