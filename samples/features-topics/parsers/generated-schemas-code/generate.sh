#!/bin/bash

xsd \
    wear/api.xml \
    /outputdir:./wear/
xsd \
    wear/api.xsd \
    /classes \
    /outputdir:./wear/

xsd \
    support-core-ui/api.xml \
    /outputdir:./support-core-ui/
xsd \
    support-core-ui/api.xsd \
    /classes \
    /outputdir:./support-core-ui/

xsd \
    support-core-utils/api.xml \
    /outputdir:./support-core-utils/
xsd \
    support-core-utils/api.xsd \
    /classes \
    /outputdir:./support-core-utils/

xsd \
    api-info/AndroidSupport.api-info.xml \
    /outputdir:./api-info/
xsd \
    api-info/AndroidSupport.api-info.xsd \
    /classes \
    /outputdir:./api-info/

xsd \
    api-info-previous/AndroidSupport.api-info.previous.xml \
    /outputdir:./api-info-previous/
xsd \
    api-info-previous/AndroidSupport.api-info.previous.xsd \
    /classes \
    /outputdir:./api-info-previous/

xsd \
    api-diff/AndroidSupport.api-diff.xml \
    /outputdir:./api-diff/
xsd \
    api-diff/AndroidSupport.api-diff.xsd \
    /classes \
    /outputdir:./api-diff/


