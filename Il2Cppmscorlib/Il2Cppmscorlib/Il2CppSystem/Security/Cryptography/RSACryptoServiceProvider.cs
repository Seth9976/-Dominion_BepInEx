using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMono.Security.Cryptography;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x020002FF RID: 767
	public sealed class RSACryptoServiceProvider : RSA
	{
		// Token: 0x06003216 RID: 12822 RVA: 0x000F7F0C File Offset: 0x000F610C
		// Note: this type is marked as 'beforefieldinit'.
		static RSACryptoServiceProvider()
		{
			Il2CppClassPointerStore<RSACryptoServiceProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "RSACryptoServiceProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RSACryptoServiceProvider>.NativeClassPtr);
			RSACryptoServiceProvider.NativeFieldInfoPtr_s_UseMachineKeyStore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSACryptoServiceProvider>.NativeClassPtr, "s_UseMachineKeyStore");
			RSACryptoServiceProvider.NativeFieldInfoPtr_store = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSACryptoServiceProvider>.NativeClassPtr, "store");
			RSACryptoServiceProvider.NativeFieldInfoPtr_persistKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSACryptoServiceProvider>.NativeClassPtr, "persistKey");
			RSACryptoServiceProvider.NativeFieldInfoPtr_persisted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSACryptoServiceProvider>.NativeClassPtr, "persisted");
			RSACryptoServiceProvider.NativeFieldInfoPtr_privateKeyExportable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSACryptoServiceProvider>.NativeClassPtr, "privateKeyExportable");
			RSACryptoServiceProvider.NativeFieldInfoPtr_m_disposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSACryptoServiceProvider>.NativeClassPtr, "m_disposed");
			RSACryptoServiceProvider.NativeFieldInfoPtr_rsa = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSACryptoServiceProvider>.NativeClassPtr, "rsa");
			RSACryptoServiceProvider.NativeMethodInfoPtr_get_UseMachineKeyStore_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSACryptoServiceProvider>.NativeClassPtr, 100671115);
			RSACryptoServiceProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSACryptoServiceProvider>.NativeClassPtr, 100671116);
			RSACryptoServiceProvider.NativeMethodInfoPtr__ctor_Public_Void_CspParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSACryptoServiceProvider>.NativeClassPtr, 100671117);
			RSACryptoServiceProvider.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSACryptoServiceProvider>.NativeClassPtr, 100671118);
			RSACryptoServiceProvider.NativeMethodInfoPtr__ctor_Public_Void_Int32_CspParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSACryptoServiceProvider>.NativeClassPtr, 100671119);
			RSACryptoServiceProvider.NativeMethodInfoPtr_Common_Private_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSACryptoServiceProvider>.NativeClassPtr, 100671120);
			RSACryptoServiceProvider.NativeMethodInfoPtr_Common_Private_Void_CspParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSACryptoServiceProvider>.NativeClassPtr, 100671121);
			RSACryptoServiceProvider.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSACryptoServiceProvider>.NativeClassPtr, 100671122);
			RSACryptoServiceProvider.NativeMethodInfoPtr_get_KeySize_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSACryptoServiceProvider>.NativeClassPtr, 100671123);
			RSACryptoServiceProvider.NativeMethodInfoPtr_get_PublicOnly_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSACryptoServiceProvider>.NativeClassPtr, 100671124);
			RSACryptoServiceProvider.NativeMethodInfoPtr_ExportParameters_Public_Virtual_RSAParameters_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSACryptoServiceProvider>.NativeClassPtr, 100671125);
			RSACryptoServiceProvider.NativeMethodInfoPtr_ImportParameters_Public_Virtual_Void_RSAParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSACryptoServiceProvider>.NativeClassPtr, 100671126);
			RSACryptoServiceProvider.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSACryptoServiceProvider>.NativeClassPtr, 100671127);
			RSACryptoServiceProvider.NativeMethodInfoPtr_OnKeyGenerated_Private_Void_Object_EventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSACryptoServiceProvider>.NativeClassPtr, 100671128);
		}

		// Token: 0x17000C18 RID: 3096
		// (get) Token: 0x06003217 RID: 12823 RVA: 0x000F80E0 File Offset: 0x000F62E0
		public unsafe static bool UseMachineKeyStore
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340428, XrefRangeEnd = 340431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RSACryptoServiceProvider.NativeMethodInfoPtr_get_UseMachineKeyStore_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003218 RID: 12824 RVA: 0x000F8110 File Offset: 0x000F6310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340431, XrefRangeEnd = 340433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RSACryptoServiceProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RSACryptoServiceProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RSACryptoServiceProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003219 RID: 12825 RVA: 0x000F814C File Offset: 0x000F634C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 340440, RefRangeEnd = 340442, XrefRangeStart = 340433, XrefRangeEnd = 340440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RSACryptoServiceProvider(CspParameters parameters)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RSACryptoServiceProvider>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parameters);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RSACryptoServiceProvider.NativeMethodInfoPtr__ctor_Public_Void_CspParameters_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600321A RID: 12826 RVA: 0x000F8198 File Offset: 0x000F6398
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 340444, RefRangeEnd = 340447, XrefRangeStart = 340442, XrefRangeEnd = 340444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RSACryptoServiceProvider(int dwKeySize)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RSACryptoServiceProvider>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dwKeySize;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RSACryptoServiceProvider.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600321B RID: 12827 RVA: 0x000F81E0 File Offset: 0x000F63E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340447, XrefRangeEnd = 340454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RSACryptoServiceProvider(int dwKeySize, CspParameters parameters)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RSACryptoServiceProvider>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dwKeySize;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parameters);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RSACryptoServiceProvider.NativeMethodInfoPtr__ctor_Public_Void_Int32_CspParameters_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600321C RID: 12828 RVA: 0x000F823C File Offset: 0x000F643C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 340498, RefRangeEnd = 340503, XrefRangeStart = 340454, XrefRangeEnd = 340498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Common(int dwKeySize, bool parameters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dwKeySize;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref parameters;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RSACryptoServiceProvider.NativeMethodInfoPtr_Common_Private_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600321D RID: 12829 RVA: 0x000F8288 File Offset: 0x000F6488
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340503, XrefRangeEnd = 340508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Common(CspParameters p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RSACryptoServiceProvider.NativeMethodInfoPtr_Common_Private_Void_CspParameters_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600321E RID: 12830 RVA: 0x000F82CC File Offset: 0x000F64CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RSACryptoServiceProvider.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000C19 RID: 3097
		// (get) Token: 0x0600321F RID: 12831 RVA: 0x000F8300 File Offset: 0x000F6500
		public unsafe override int KeySize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RSACryptoServiceProvider.NativeMethodInfoPtr_get_KeySize_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C1A RID: 3098
		// (get) Token: 0x06003220 RID: 12832 RVA: 0x000F833C File Offset: 0x000F653C
		public unsafe bool PublicOnly
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 340510, RefRangeEnd = 340512, XrefRangeStart = 340508, XrefRangeEnd = 340510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RSACryptoServiceProvider.NativeMethodInfoPtr_get_PublicOnly_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003221 RID: 12833 RVA: 0x000F8378 File Offset: 0x000F6578
		[CallerCount(0)]
		public unsafe override RSAParameters ExportParameters(bool includePrivateParameters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref includePrivateParameters;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RSACryptoServiceProvider.NativeMethodInfoPtr_ExportParameters_Public_Virtual_RSAParameters_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new RSAParameters(intPtr);
			}
		}

		// Token: 0x06003222 RID: 12834 RVA: 0x000F83BC File Offset: 0x000F65BC
		[CallerCount(0)]
		public unsafe override void ImportParameters(RSAParameters parameters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(parameters));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RSACryptoServiceProvider.NativeMethodInfoPtr_ImportParameters_Public_Virtual_Void_RSAParameters_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003223 RID: 12835 RVA: 0x000F8404 File Offset: 0x000F6604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340512, XrefRangeEnd = 340514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RSACryptoServiceProvider.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003224 RID: 12836 RVA: 0x000F8444 File Offset: 0x000F6644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340514, XrefRangeEnd = 340517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnKeyGenerated(Object sender, EventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RSACryptoServiceProvider.NativeMethodInfoPtr_OnKeyGenerated_Private_Void_Object_EventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003225 RID: 12837 RVA: 0x00011CDE File Offset: 0x0000FEDE
		public RSACryptoServiceProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C11 RID: 3089
		// (get) Token: 0x06003226 RID: 12838 RVA: 0x000F8498 File Offset: 0x000F6698
		// (set) Token: 0x06003227 RID: 12839 RVA: 0x00011CE7 File Offset: 0x0000FEE7
		public unsafe static CspProviderFlags s_UseMachineKeyStore
		{
			get
			{
				CspProviderFlags cspProviderFlags;
				IL2CPP.il2cpp_field_static_get_value(RSACryptoServiceProvider.NativeFieldInfoPtr_s_UseMachineKeyStore, (void*)(&cspProviderFlags));
				return cspProviderFlags;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RSACryptoServiceProvider.NativeFieldInfoPtr_s_UseMachineKeyStore, (void*)(&value));
			}
		}

		// Token: 0x17000C12 RID: 3090
		// (get) Token: 0x06003228 RID: 12840 RVA: 0x000F84B4 File Offset: 0x000F66B4
		// (set) Token: 0x06003229 RID: 12841 RVA: 0x00011CF5 File Offset: 0x0000FEF5
		public unsafe KeyPairPersistence store
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSACryptoServiceProvider.NativeFieldInfoPtr_store);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<KeyPairPersistence>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSACryptoServiceProvider.NativeFieldInfoPtr_store), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C13 RID: 3091
		// (get) Token: 0x0600322A RID: 12842 RVA: 0x000F84E4 File Offset: 0x000F66E4
		// (set) Token: 0x0600322B RID: 12843 RVA: 0x00011D14 File Offset: 0x0000FF14
		public unsafe bool persistKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSACryptoServiceProvider.NativeFieldInfoPtr_persistKey);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSACryptoServiceProvider.NativeFieldInfoPtr_persistKey)) = value;
			}
		}

		// Token: 0x17000C14 RID: 3092
		// (get) Token: 0x0600322C RID: 12844 RVA: 0x000F850C File Offset: 0x000F670C
		// (set) Token: 0x0600322D RID: 12845 RVA: 0x00011D2F File Offset: 0x0000FF2F
		public unsafe bool persisted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSACryptoServiceProvider.NativeFieldInfoPtr_persisted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSACryptoServiceProvider.NativeFieldInfoPtr_persisted)) = value;
			}
		}

		// Token: 0x17000C15 RID: 3093
		// (get) Token: 0x0600322E RID: 12846 RVA: 0x000F8534 File Offset: 0x000F6734
		// (set) Token: 0x0600322F RID: 12847 RVA: 0x00011D4A File Offset: 0x0000FF4A
		public unsafe bool privateKeyExportable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSACryptoServiceProvider.NativeFieldInfoPtr_privateKeyExportable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSACryptoServiceProvider.NativeFieldInfoPtr_privateKeyExportable)) = value;
			}
		}

		// Token: 0x17000C16 RID: 3094
		// (get) Token: 0x06003230 RID: 12848 RVA: 0x000F855C File Offset: 0x000F675C
		// (set) Token: 0x06003231 RID: 12849 RVA: 0x00011D65 File Offset: 0x0000FF65
		public unsafe bool m_disposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSACryptoServiceProvider.NativeFieldInfoPtr_m_disposed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSACryptoServiceProvider.NativeFieldInfoPtr_m_disposed)) = value;
			}
		}

		// Token: 0x17000C17 RID: 3095
		// (get) Token: 0x06003232 RID: 12850 RVA: 0x000F8584 File Offset: 0x000F6784
		// (set) Token: 0x06003233 RID: 12851 RVA: 0x00011D80 File Offset: 0x0000FF80
		public unsafe RSAManaged rsa
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSACryptoServiceProvider.NativeFieldInfoPtr_rsa);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RSAManaged>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSACryptoServiceProvider.NativeFieldInfoPtr_rsa), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002AD2 RID: 10962
		private static readonly IntPtr NativeFieldInfoPtr_s_UseMachineKeyStore;

		// Token: 0x04002AD3 RID: 10963
		private static readonly IntPtr NativeFieldInfoPtr_store;

		// Token: 0x04002AD4 RID: 10964
		private static readonly IntPtr NativeFieldInfoPtr_persistKey;

		// Token: 0x04002AD5 RID: 10965
		private static readonly IntPtr NativeFieldInfoPtr_persisted;

		// Token: 0x04002AD6 RID: 10966
		private static readonly IntPtr NativeFieldInfoPtr_privateKeyExportable;

		// Token: 0x04002AD7 RID: 10967
		private static readonly IntPtr NativeFieldInfoPtr_m_disposed;

		// Token: 0x04002AD8 RID: 10968
		private static readonly IntPtr NativeFieldInfoPtr_rsa;

		// Token: 0x04002AD9 RID: 10969
		private static readonly IntPtr NativeMethodInfoPtr_get_UseMachineKeyStore_Public_Static_get_Boolean_0;

		// Token: 0x04002ADA RID: 10970
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002ADB RID: 10971
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_CspParameters_0;

		// Token: 0x04002ADC RID: 10972
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04002ADD RID: 10973
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_CspParameters_0;

		// Token: 0x04002ADE RID: 10974
		private static readonly IntPtr NativeMethodInfoPtr_Common_Private_Void_Int32_Boolean_0;

		// Token: 0x04002ADF RID: 10975
		private static readonly IntPtr NativeMethodInfoPtr_Common_Private_Void_CspParameters_0;

		// Token: 0x04002AE0 RID: 10976
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04002AE1 RID: 10977
		private static readonly IntPtr NativeMethodInfoPtr_get_KeySize_Public_Virtual_get_Int32_0;

		// Token: 0x04002AE2 RID: 10978
		private static readonly IntPtr NativeMethodInfoPtr_get_PublicOnly_Public_get_Boolean_0;

		// Token: 0x04002AE3 RID: 10979
		private static readonly IntPtr NativeMethodInfoPtr_ExportParameters_Public_Virtual_RSAParameters_Boolean_0;

		// Token: 0x04002AE4 RID: 10980
		private static readonly IntPtr NativeMethodInfoPtr_ImportParameters_Public_Virtual_Void_RSAParameters_0;

		// Token: 0x04002AE5 RID: 10981
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x04002AE6 RID: 10982
		private static readonly IntPtr NativeMethodInfoPtr_OnKeyGenerated_Private_Void_Object_EventArgs_0;
	}
}
