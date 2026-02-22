using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Unity.Collections;

namespace UnityEngine.Experimental.GlobalIllumination
{
	// Token: 0x02000164 RID: 356
	public static class Lightmapping : Object
	{
		// Token: 0x06001AAE RID: 6830 RVA: 0x0005F5C0 File Offset: 0x0005D7C0
		// Note: this type is marked as 'beforefieldinit'.
		static Lightmapping()
		{
			Il2CppClassPointerStore<Lightmapping>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.GlobalIllumination", "Lightmapping");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Lightmapping>.NativeClassPtr);
			Lightmapping.NativeFieldInfoPtr_s_DefaultDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lightmapping>.NativeClassPtr, "s_DefaultDelegate");
			Lightmapping.NativeFieldInfoPtr_s_RequestLightsDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lightmapping>.NativeClassPtr, "s_RequestLightsDelegate");
			Lightmapping.NativeMethodInfoPtr_SetDelegate_Public_Static_Void_RequestLightsDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lightmapping>.NativeClassPtr, 100665256);
			Lightmapping.NativeMethodInfoPtr_GetDelegate_Public_Static_RequestLightsDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lightmapping>.NativeClassPtr, 100665257);
			Lightmapping.NativeMethodInfoPtr_ResetDelegate_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lightmapping>.NativeClassPtr, 100665258);
			Lightmapping.NativeMethodInfoPtr_RequestLights_Internal_Static_Void_Il2CppReferenceArray_1_Light_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lightmapping>.NativeClassPtr, 100665259);
		}

		// Token: 0x06001AAF RID: 6831 RVA: 0x0005F668 File Offset: 0x0005D868
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83104, XrefRangeEnd = 83110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetDelegate(Lightmapping.RequestLightsDelegate del)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(del);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lightmapping.NativeMethodInfoPtr_SetDelegate_Public_Static_Void_RequestLightsDelegate_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001AB0 RID: 6832 RVA: 0x0005F6A0 File Offset: 0x0005D8A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83110, XrefRangeEnd = 83114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Lightmapping.RequestLightsDelegate GetDelegate()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lightmapping.NativeMethodInfoPtr_GetDelegate_Public_Static_RequestLightsDelegate_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Lightmapping.RequestLightsDelegate>(intPtr3) : null;
		}

		// Token: 0x06001AB1 RID: 6833 RVA: 0x0005F6D4 File Offset: 0x0005D8D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83114, XrefRangeEnd = 83118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ResetDelegate()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lightmapping.NativeMethodInfoPtr_ResetDelegate_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AB2 RID: 6834 RVA: 0x0005F6FC File Offset: 0x0005D8FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83118, XrefRangeEnd = 83127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RequestLights(Il2CppReferenceArray<Light> lights, IntPtr outLightsPtr, int outLightsCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lights);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref outLightsPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref outLightsCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lightmapping.NativeMethodInfoPtr_RequestLights_Internal_Static_Void_Il2CppReferenceArray_1_Light_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AB3 RID: 6835 RVA: 0x0000EBE7 File Offset: 0x0000CDE7
		public Lightmapping(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x06001AB4 RID: 6836 RVA: 0x0005F750 File Offset: 0x0005D950
		// (set) Token: 0x06001AB5 RID: 6837 RVA: 0x0000EBF0 File Offset: 0x0000CDF0
		public unsafe static Lightmapping.RequestLightsDelegate s_DefaultDelegate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Lightmapping.NativeFieldInfoPtr_s_DefaultDelegate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Lightmapping.RequestLightsDelegate>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Lightmapping.NativeFieldInfoPtr_s_DefaultDelegate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x06001AB6 RID: 6838 RVA: 0x0005F778 File Offset: 0x0005D978
		// (set) Token: 0x06001AB7 RID: 6839 RVA: 0x0000EC02 File Offset: 0x0000CE02
		public unsafe static Lightmapping.RequestLightsDelegate s_RequestLightsDelegate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Lightmapping.NativeFieldInfoPtr_s_RequestLightsDelegate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Lightmapping.RequestLightsDelegate>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Lightmapping.NativeFieldInfoPtr_s_RequestLightsDelegate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001417 RID: 5143
		private static readonly IntPtr NativeFieldInfoPtr_s_DefaultDelegate;

		// Token: 0x04001418 RID: 5144
		private static readonly IntPtr NativeFieldInfoPtr_s_RequestLightsDelegate;

		// Token: 0x04001419 RID: 5145
		private static readonly IntPtr NativeMethodInfoPtr_SetDelegate_Public_Static_Void_RequestLightsDelegate_0;

		// Token: 0x0400141A RID: 5146
		private static readonly IntPtr NativeMethodInfoPtr_GetDelegate_Public_Static_RequestLightsDelegate_0;

		// Token: 0x0400141B RID: 5147
		private static readonly IntPtr NativeMethodInfoPtr_ResetDelegate_Public_Static_Void_0;

		// Token: 0x0400141C RID: 5148
		private static readonly IntPtr NativeMethodInfoPtr_RequestLights_Internal_Static_Void_Il2CppReferenceArray_1_Light_IntPtr_Int32_0;

		// Token: 0x02000A05 RID: 2565
		public sealed class RequestLightsDelegate : MulticastDelegate
		{
			// Token: 0x06003228 RID: 12840 RVA: 0x0001783E File Offset: 0x00015A3E
			// Note: this type is marked as 'beforefieldinit'.
			static RequestLightsDelegate()
			{
				Il2CppClassPointerStore<Lightmapping.RequestLightsDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Lightmapping>.NativeClassPtr, "RequestLightsDelegate");
				Lightmapping.RequestLightsDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lightmapping.RequestLightsDelegate>.NativeClassPtr, 100665261);
				Lightmapping.RequestLightsDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Il2CppReferenceArray_1_Light_NativeArray_1_LightDataGI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lightmapping.RequestLightsDelegate>.NativeClassPtr, 100665262);
			}

			// Token: 0x06003229 RID: 12841 RVA: 0x0006E734 File Offset: 0x0006C934
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RequestLightsDelegate(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Lightmapping.RequestLightsDelegate>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lightmapping.RequestLightsDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600322A RID: 12842 RVA: 0x0006E790 File Offset: 0x0006C990
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 83079, RefRangeEnd = 83080, XrefRangeStart = 83060, XrefRangeEnd = 83079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(Il2CppReferenceArray<Light> requests, Unity.Collections.NativeArray<LightDataGI> lightsOutput)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(requests);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(lightsOutput));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lightmapping.RequestLightsDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Il2CppReferenceArray_1_Light_NativeArray_1_LightDataGI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600322B RID: 12843 RVA: 0x0001787C File Offset: 0x00015A7C
			public RequestLightsDelegate(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600322C RID: 12844 RVA: 0x00017885 File Offset: 0x00015A85
			public static implicit operator Lightmapping.RequestLightsDelegate(Action<Il2CppReferenceArray<Light>, Unity.Collections.NativeArray<LightDataGI>> A_0)
			{
				return DelegateSupport.ConvertDelegate<Lightmapping.RequestLightsDelegate>(A_0);
			}

			// Token: 0x0600322D RID: 12845 RVA: 0x0001788D File Offset: 0x00015A8D
			public static Lightmapping.RequestLightsDelegate operator +(Lightmapping.RequestLightsDelegate A_0, Lightmapping.RequestLightsDelegate A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<Lightmapping.RequestLightsDelegate>();
			}

			// Token: 0x0600322E RID: 12846 RVA: 0x0001789B File Offset: 0x00015A9B
			public static Lightmapping.RequestLightsDelegate operator -(Lightmapping.RequestLightsDelegate A_0, Lightmapping.RequestLightsDelegate A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<Lightmapping.RequestLightsDelegate>();
				}
				return delegate2;
			}

			// Token: 0x04001D38 RID: 7480
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001D39 RID: 7481
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Il2CppReferenceArray_1_Light_NativeArray_1_LightDataGI_0;
		}

		// Token: 0x02000A06 RID: 2566
		[ObfuscatedName("UnityEngine.Experimental.GlobalIllumination.Lightmapping+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600322F RID: 12847 RVA: 0x0006E7EC File Offset: 0x0006C9EC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Lightmapping.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Lightmapping>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Lightmapping.__c>.NativeClassPtr);
				Lightmapping.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lightmapping.__c>.NativeClassPtr, "<>9");
				Lightmapping.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lightmapping.__c>.NativeClassPtr, 100665264);
				Lightmapping.__c.NativeMethodInfoPtr___cctor_b__7_0_Internal_Void_Il2CppReferenceArray_1_Light_NativeArray_1_LightDataGI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lightmapping.__c>.NativeClassPtr, 100665265);
			}

			// Token: 0x06003230 RID: 12848 RVA: 0x0006E854 File Offset: 0x0006CA54
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Lightmapping.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lightmapping.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003231 RID: 12849 RVA: 0x0006E890 File Offset: 0x0006CA90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83080, XrefRangeEnd = 83104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__7_0(Il2CppReferenceArray<Light> requests, Unity.Collections.NativeArray<LightDataGI> lightsOutput)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(requests);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(lightsOutput));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lightmapping.__c.NativeMethodInfoPtr___cctor_b__7_0_Internal_Void_Il2CppReferenceArray_1_Light_NativeArray_1_LightDataGI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003232 RID: 12850 RVA: 0x000178AC File Offset: 0x00015AAC
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000781 RID: 1921
			// (get) Token: 0x06003233 RID: 12851 RVA: 0x0006E8EC File Offset: 0x0006CAEC
			// (set) Token: 0x06003234 RID: 12852 RVA: 0x000178B5 File Offset: 0x00015AB5
			public unsafe static Lightmapping.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Lightmapping.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Lightmapping.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Lightmapping.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001D3A RID: 7482
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001D3B RID: 7483
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001D3C RID: 7484
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__7_0_Internal_Void_Il2CppReferenceArray_1_Light_NativeArray_1_LightDataGI_0;
		}

		// Token: 0x02000A07 RID: 2567
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
